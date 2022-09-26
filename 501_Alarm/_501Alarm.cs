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
    public partial class _501Alarm : Form
    {
        /// <summary>
        /// tracks if an alarm is being edited
        /// </summary>
        public bool BeingEdited = false;

        /// <summary>
        /// lilst of alarms to store
        /// </summary>
        public BindingList<Alarm> AlarmList = new BindingList<Alarm>();

        /// <summary>
        /// gets the status of the alarms
        /// </summary>
        public bool AlarmStatus { get; set; }
        /// <summary>
        /// counts the number the alarms
        /// </summary>
        public int Count { get; set; } = 0;

        System.Timers.Timer _stopTimer = new System.Timers.Timer(1000);

        public int snoozeTime = 1;

        System.Timers.Timer _snoozeTimer = new System.Timers.Timer(1);

        private CheckAlarmsHelper checkAlarmsHelper;

        private SnoozeHelper snoozeHelper;

        private AddClickHelper addClickHelper;

        private ReadFileHelper readFileHelper;  

        private EditClickHelper editClickHelper;

        private CheckSnoozed checkSnoozed;

        private StopClickHelper stopClickHelper;

        private SetForm1Controller setForm1Controller;

        private CurrentAlarmTime currentAlarmTime;

        private CurrentChecked currentChecked;

        private AddEditAlarm form2;

        public _501Alarm(AddEditAlarm aea)
        {
            InitializeComponent();
            form2 = aea;
            uxalarmList.DataSource = AlarmList;

            _stopTimer.Elapsed += this.CheckAlarms;
            _stopTimer.SynchronizingObject = uxalarmAlert;
            _stopTimer.AutoReset = true;
            _stopTimer.Start();
        }

        public void SetController(CheckAlarmsHelper cah, SnoozeHelper sah, AddClickHelper ach, ReadFileHelper rfh, EditClickHelper ech, CheckSnoozed cs, StopClickHelper sch, SetForm1Controller sfc, CurrentAlarmTime cat, CurrentChecked cc)
        {
            checkAlarmsHelper = cah;
            snoozeHelper = sah;
            addClickHelper = ach;
            readFileHelper = rfh;   
            editClickHelper = ech;
            checkSnoozed = cs;
            stopClickHelper = sch;  
            setForm1Controller = sfc;
            currentAlarmTime = cat;
            currentChecked = cc;
        }

        public void IncrementCount()
        {
            Count++;
        }

        public void HideEditAlarm(AddEditAlarm e)
        {
            e.Hide();
        }

        public bool GetBeingEditedValue()
        {
            return BeingEdited;
        }

        public void Editing(bool b)
        {
            BeingEdited = b;
            uxeditButton.Enabled = false;
        }

        public void SetBeingEnabledTrue()
        {
            BeingEdited = true;
        }

        public BindingList<Alarm> GetAlarmList()
        {
            return AlarmList;
        }

        public _501Alarm GetForm1()
        {
            return this;
        }

        public void UpdateStopTimer(Alarm alarm)
        {
            alarm.Stopped = true;
            uxalarmAlert.Text = "Alarm " + AlarmList.IndexOf(alarm).ToString() + " has gone off!: " + alarm.Sounds;
            uxsnoozeButton.Enabled = true;
            uxstopButton.Enabled = true;
        }

        public void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            checkAlarmsHelper(AlarmList);
        }

        public void AddButtonDisabled()
        {
            if(Count >= 5)
            {
                uxaddButton.Enabled = false;
            }
        }

        public void UpdateSnooze(Alarm alarm)
        {
            uxalarmAlert.Text = "Alarm " + AlarmList.IndexOf(alarm).ToString() + " has gone off!: " + alarm.Sounds;
            uxsnoozeButton.Enabled = true;
            uxstopButton.Enabled = true;
        }

        public void SnoozeAlarms(object sender, ElapsedEventArgs e)
        {
            snoozeHelper(AlarmList);
            _snoozeTimer.Stop();
        }

        private void uxaddButton_Click(object sender, EventArgs e)
        {
            addClickHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(this);
            readFileHelper();
        }

        private void uxeditButton_Click(object sender, EventArgs e)
        {
            editClickHelper(uxalarmList.SelectedItem, uxalarmList.SelectedIndex, AlarmList, form2);
        }

        private void uxalarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxeditButton.Enabled = true;
        }

        private void uxsnoozeButton_Click(object sender, EventArgs e)
        {
            _snoozeTimer = new System.Timers.Timer((int)uxSnoozeTimePicker.Value * 1000);
            checkSnoozed(AlarmList);
            uxalarmAlert.Text = "";
            _snoozeTimer.Elapsed += this.SnoozeAlarms;
            _snoozeTimer.AutoReset = true;
            _snoozeTimer.SynchronizingObject = uxalarmAlert;
            _snoozeTimer.Start();
        }

        private void uxstopButton_Click(object sender, EventArgs e)
        {
            stopClickHelper(AlarmList);
            uxstopButton.Enabled = false;
            uxsnoozeButton.Enabled = false;
            uxalarmAlert.Text = "";
        }
    }
}