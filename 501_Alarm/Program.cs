using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _501_Alarm
{
    public delegate void IncrementCount();
    public delegate BindingList<Alarm> GetAlarmList();
    public delegate void AddButtonDisabled();
    public delegate bool GetBeingEditedValue();
    public delegate void HideEditAlarm(AddEditAlarm e);
    public delegate void SetBeingEnabledTrue();
    public delegate _501Alarm GetForm1();
    public delegate void UpdateStopTimer(Alarm alarm);
    public delegate void UpdateSnooze(Alarm alarm);
    public delegate void Editing(bool b);
    public delegate void CheckAlarmsHelper(BindingList<Alarm> alarmList);
    public delegate void SnoozeHelper(BindingList<Alarm> alarmList);
    public delegate void AddClickHelper();
    public delegate void ReadFileHelper();
    public delegate void EditClickHelper(object o, int i, BindingList<Alarm> alarmList, AddEditAlarm a);
    public delegate void CheckSnoozed(BindingList<Alarm> alarmList);
    public delegate void StopClickHelper(BindingList<Alarm> alarmList);
    public delegate Controller SetForm1Controller();
    public delegate void SetClickHelper(DateTime d, bool b, AddEditAlarm a, BindingList<Alarm> alarmList);
    public delegate void SetSounds(Sound sound);
    public delegate DateTime CurrentAlarmTime(BindingList<Alarm> al);
    public delegate bool CurrentChecked(BindingList<Alarm> al);
    public delegate void ChangedCheckbox(bool b);
    public delegate void ChangeDateTime(DateTime t);

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AddEditAlarm view2 = new AddEditAlarm(false, DateTime.Now);
            _501Alarm view1 = new _501Alarm(view2);


            Controller c = new Controller(view1.IncrementCount, view1.GetAlarmList, view1.AddButtonDisabled, view1.GetBeingEditedValue, view1.HideEditAlarm,
                view1.SetBeingEnabledTrue, view1.GetForm1, view1.UpdateStopTimer, view1.UpdateSnooze, view1.Editing, view2.ChangeCheckbox, view2.ChangeDateTime);

            view1.SetController(c.CheckAlarmsHelper, c.SnoozeHelper, c.AddClickHelper, c.ReadFileHelper, c.EditClickHelper, c.CheckSnoozed, c.StopClickHelper, c.SetForm1Controller, c.CurrentAlarmTime, c.CurrentChecked);
            
            view2.SetEditController(c.SetClickHelper, c.SetSounds, view1);

            Application.Run(view1);
        }
    }
}
