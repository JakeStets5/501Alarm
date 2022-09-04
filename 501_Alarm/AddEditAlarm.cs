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

        private bool _alarmStatus;

        public AddEditAlarm(Form1 form1, bool checkEnabled, DateTime dateTime)
        {
            InitializeComponent();
            uxtimePicker.Format = DateTimePickerFormat.Time;
            MainForm = form1;   
            uxonCheckBox.Checked = checkEnabled;
            uxtimePicker.Value = dateTime;
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
            uxtimePicker.Format = DateTimePickerFormat.Time;
            uxtimePicker.CustomFormat = "hh:mm tt";
            if (MainForm.BeingEdited)
            {
                if(_alarmStatus) MainForm.EditChanges(uxtimePicker.Value, true);
                else MainForm.EditChanges(uxtimePicker.Value, false);
            }
            else if (!MainForm.BeingEdited)
            {
                if (_alarmStatus)
                {
                    MainForm.AddListItem(uxtimePicker.Value, true, MainForm.Count);
                }
                else if (!_alarmStatus)
                {
                    MainForm.AddListItem(uxtimePicker.Value, false, MainForm.Count);
                }
            }
            MainForm.AddToTextFile();
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
