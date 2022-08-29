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
        private Form1 MainForm;

        public bool EditCheckEnabled;

        public DateTime EditDateTime;

        private bool _alarmStatus;

        public AddEditAlarm(Form1 form1, bool checkEnabled, DateTime dateTime)
        {
            InitializeComponent();
            uxtimePicker.Format = DateTimePickerFormat.Time;
            MainForm = form1;   
            EditCheckEnabled = checkEnabled;
            EditDateTime = dateTime;
            uxonCheckBox.Checked = EditCheckEnabled;
            uxtimePicker.Value = EditDateTime;
        }

        /// <summary>
        /// setting up a form 1 var
        /// </summary>
        public AddEditAlarm(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void uxcancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uxsetButton_Click(object sender, EventArgs e)
        {
            uxtimePicker.Format = DateTimePickerFormat.Custom;
            uxtimePicker.CustomFormat = "hh:mm tt";
            if (MainForm.BeingEdited)
            {
                MainForm.EditChanges(uxtimePicker.Value, true);
            }
            else if (!MainForm.BeingEdited)
            {
                if (_alarmStatus)
                {
                    Alarm alarm = new Alarm();
                    MainForm.CurrentAlarm.Time = uxtimePicker.Value;
                    MainForm.CurrentAlarm.Checked = true;
                    MainForm.CurrentAlarm.Index = MainForm.Count;
                    MainForm.AddListItem(MainForm.CurrentAlarm.ToString());

                }
                else if (!_alarmStatus)
                {
                    Alarm alarm = new Alarm();
                    MainForm.CurrentAlarm.Time = uxtimePicker.Value;
                    MainForm.CurrentAlarm.Checked = false;
                    MainForm.CurrentAlarm.Index = MainForm.Count;
                    MainForm.AddListItem(MainForm.CurrentAlarm.ToString());
                }
            }
            MainForm.Count++;
            MainForm.AddButtonDisabled();
            this.Hide();
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
    }
}
