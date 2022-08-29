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

namespace _501_Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists())
            {

            }
        }
        /// <summary>
        /// tracks if an alarm is being edited
        /// </summary>
        public bool BeingEdited = false;

        /// <summary>
        /// deals with the current alarm
        /// </summary>
        public Alarm CurrentAlarm = new Alarm();


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
        public void AddListItem(string item)
        {
            uxalarmList.Items.Add(item);
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
                AddEditAlarm editAlarm = new AddEditAlarm(this, CurrentAlarm.Checked, CurrentAlarm.Time);
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
                if (loopCounter == CurrentAlarm.Index)
                {
                    uxalarmList.Items.Remove(uxalarmList.Items[loopCounter]);
                    CurrentAlarm.Checked = onOff;
                    CurrentAlarm.Time = dateTime;
                    AddListItem(CurrentAlarm.ToString());
                    BeingEdited = false;
                    break;
                }
            }
        }

        private void uxalarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxeditButton.Enabled = true;

        }
    }
}
