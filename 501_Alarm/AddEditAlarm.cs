using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _501_Alarm
{
    public partial class AddEditAlarm : Form
    {
        private _501Alarm MainForm;

        private bool _alarmStatus;

        private SetClickHelper setClickHelper;

        private SetSounds setSounds;

        public DateTime Time;

        public bool Checked;

        public AddEditAlarm(bool checkEnabled, DateTime dateTime)
        {
            InitializeComponent();
            uxtimePicker.Format = DateTimePickerFormat.Time;   
            uxonCheckBox.Checked = checkEnabled;
            uxtimePicker.Value = dateTime;
        }

        /// <summary>
        /// setting up a form 1 var
        /// </summary>
        public AddEditAlarm(Form callingForm)
        {
            MainForm = callingForm as _501Alarm;
            InitializeComponent();
        }

        public void ChangeCheckbox(bool check)
        {
            uxonCheckBox.Checked = check;
        }

        public void ChangeDateTime(DateTime time)
        {
            uxtimePicker.Value = time;
        }

        private void uxcancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void SetEditController(SetClickHelper sch, SetSounds ss, _501Alarm a)
        {
            setClickHelper = sch;
            setSounds = ss;
            MainForm = a;
        }

        private void uxsetButton_Click(object sender, EventArgs e)
        {
            uxtimePicker.Format = DateTimePickerFormat.Time;
            uxtimePicker.CustomFormat = "hh:mm tt";
            setClickHelper(uxtimePicker.Value, _alarmStatus, this, MainForm.AlarmList);
        }

        private void uxonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (uxonCheckBox.Checked)
            {
                _alarmStatus = true;    
            }
            else
            {
                _alarmStatus = false;
            }
        }

        private void radarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSounds(Sound.Radar);
        }

        private void chimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSounds(Sound.Chimes);
        }

        private void beaconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSounds(Sound.Beacon);
        }

        private void circuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSounds(Sound.Circuit);
        }

        private void reflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSounds(Sound.Reflection);
        }
    }
}
