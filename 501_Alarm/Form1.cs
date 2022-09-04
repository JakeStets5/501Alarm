using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace _501_Alarm
{
    public partial class Form1 : Form
    {

        private string _path = @"TextFile1.txt";
        

        /// <summary>
        /// tracks if an alarm is being edited
        /// </summary>
        public bool BeingEdited = false;

        /// <summary>
        /// lilst of alarms to store
        /// </summary>
        public Alarm[] AlarmList = new Alarm[5];

        /// <summary>
        /// gets the status of the alarms
        /// </summary>
        public bool AlarmStatus { get; set; }
        /// <summary>
        /// counts the number the alarms
        /// </summary>

        public int Count { get; set; } = 0;
        /// <summary>
        /// adds an item to the list
        /// </summary>
        /// <param name="item"></param>

        public Form1()
        {
            InitializeComponent();

           if (File.Exists(_path))
            {
                StreamReader sr = new StreamReader(_path);
                while (!sr.EndOfStream)
                {
                    string readLine = sr.ReadLine();
                    if(readLine == "")
                    {
                        break;
                    }
                    string[] alarmData = readLine.Split(',');
                    AddListItem(Convert.ToDateTime(alarmData[0]), Convert.ToBoolean(alarmData[1]), Convert.ToInt32(alarmData[2]));
                    Count++;
                }
                AddButtonDisabled();
                sr.Close();
            }
            System.Timers.Timer stopTimer = new System.Timers.Timer(1000);
            stopTimer.Elapsed += this.CheckAlarms;
            stopTimer.SynchronizingObject = uxalarmAlert;
            stopTimer.AutoReset = true;
            stopTimer.Start();
            System.Timers.Timer snoozeTimer = new System.Timers.Timer(3000);
            uxalarmAlert.Text = "";
            snoozeTimer.Elapsed += this.SnoozeAlarms;
            snoozeTimer.AutoReset = true;
            snoozeTimer.SynchronizingObject = uxalarmAlert;
            snoozeTimer.Start();

        }

        public void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime current = DateTime.Now;
            
            if (AlarmList.Length > 0)
            {
                foreach (Alarm alarm in AlarmList)
                {
                    if (alarm != null)
                    {
                        if (!uxsnoozeButton.Enabled) {
                            if (alarm.Checked && current.Hour == alarm.Time.Hour && current.Minute == alarm.Time.Minute)
                            {
                                uxalarmAlert.Text = "Alarm " + alarm.Index.ToString() + " has gone off!";
                                uxsnoozeButton.Enabled = true;
                                uxstopButton.Enabled = true;
                                uxalarmList.SelectedIndex = alarm.Index;
                            }
                        }
                    }
                }
            }
        }
        
        public void AddListItem(DateTime time, bool onOff, int index)
        {
            Alarm alarm = new Alarm();
            alarm.Time = time;  
            alarm.Index = index;
            alarm.Checked = onOff;
            uxalarmList.Items.Add(alarm.ToString());
            AlarmList[index] = alarm;
        }

        public void AddToTextFile()
        {
            if (File.Exists(_path))
            {
                using (StreamWriter sw = new StreamWriter(_path))
                {
                    for (int i = 0; i < uxalarmList.Items.Count; i++)
                    {
                        sw.WriteLine(AlarmList[i].Time.ToString() + "," + AlarmList[i].Checked.ToString() + "," + AlarmList[i].Index.ToString());
                    }
                }
            }
        }

        public void AddButtonDisabled()
        {
            if(Count >= 5)
            {
                uxaddButton.Enabled = false;
            }
        }

        private void uxaddButton_Click(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(this, false, DateTime.Now);
            addEditAlarm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(this);
        }

        private void uxeditButton_Click(object sender, EventArgs e)
        {
            if(uxalarmList.SelectedItem != null)
            {   
                int index = uxalarmList.SelectedIndex;  
                string[] alarmString = uxalarmList.SelectedItem.ToString().Split(',');
                AlarmList[index].Time = Convert.ToDateTime(alarmString[0]);
                if(alarmString[1] == " ON")
                {
                    AlarmList[index].Checked = true;
                }
                else
                {
                    AlarmList[index].Checked = false;   
                }
                AddEditAlarm editAlarm = new AddEditAlarm(this, AlarmList[index].Checked, AlarmList[index].Time);
                BeingEdited = true;
                editAlarm.Show(); 
            }              
            Count--;
        }

        public void EditChanges(DateTime dateTime, bool onOff)
        {
            int loopCounter = 0;
            while(loopCounter <= Count)
            {
                if (loopCounter == uxalarmList.SelectedIndex) 
                {
                    AlarmList[loopCounter].Index = loopCounter;
                    AlarmList[loopCounter].Time = dateTime;
                    AlarmList[loopCounter].Checked = onOff;
                    uxalarmList.Items[loopCounter] = AlarmList[loopCounter];
                    BeingEdited = false;
                    uxeditButton.Enabled = false;
                    break;
                }
                loopCounter++;
            }
        }

        private void uxalarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxeditButton.Enabled = true;
        }

        private void uxsnoozeButton_Click(object sender, EventArgs e)
        {
            SnoozeTracker = true;
            uxalarmAlert.Text = "";
        }


        bool SnoozeTracker = false;
        public void SnoozeAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime current = DateTime.Now;

            if (AlarmList.Length > 0)
            {
                foreach (Alarm alarm in AlarmList)
                {
                    if (alarm != null)
                    {
                        if (SnoozeTracker)
                        {
                            if (alarm.Checked && current.Hour == alarm.Time.Hour && current.Minute == alarm.Time.Minute)
                            {
                                uxalarmAlert.Text = "Alarm " + alarm.Index.ToString() + " has gone off!";
                                uxsnoozeButton.Enabled = true;
                                uxstopButton.Enabled = true;
                                uxalarmList.SelectedIndex = alarm.Index;
                                System.Timers.Timer myTimer = sender as System.Timers.Timer;
                                myTimer.AutoReset = true;
                            }
                        }
                    }
                }
            }
        }

        private void uxstopButton_Click(object sender, EventArgs e)
        {
            int index = uxalarmList.SelectedIndex;  
            uxalarmAlert.Text = "";
            MessageBox.Show("Your alarm was stopped!");
            uxstopButton.Enabled = false;
            uxsnoozeButton.Enabled = false;
            AlarmList[index].Checked = false;
            string[] alarmString = uxalarmList.SelectedItem.ToString().Split(',');
            AlarmList[index].Time = Convert.ToDateTime(alarmString[0]);
            alarmString[1] = " OFF";
            EditChanges(AlarmList[index].Time, AlarmList[index].Checked);
            AddToTextFile();
            uxalarmAlert.Text = "";
        }
    }
}