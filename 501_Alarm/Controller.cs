using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace _501_Alarm
{
    public enum Sound
    {
        Radar,
        Beacon,
        Chimes,
        Circuit,
        Reflection
    }
    public class Controller
    {
        AddEditAlarm EditForm;

        private IncrementCount incrementCount;

        private GetAlarmList getAlarmList;

        private AddButtonDisabled addButtonDisabled;

        private GetBeingEditedValue getBeingEditedValue;

        private HideEditAlarm hideEditAlarm;

        private SetBeingEnabledTrue setBeingEnabledTrue;

        private GetForm1 getForm1;

        private UpdateStopTimer updateStopTimer;

        private UpdateSnooze updateSnooze;

        private Editing editing;

        private ChangeDateTime changeDateTime;

        private ChangedCheckbox changedCheckbox;

        private int _selectedIndex;

        public string _alarmSound;

        public Controller(IncrementCount ic, GetAlarmList gal, AddButtonDisabled abd, GetBeingEditedValue gbev, HideEditAlarm hea, SetBeingEnabledTrue sbet, GetForm1 gf, UpdateStopTimer ust, UpdateSnooze us, Editing e, ChangedCheckbox cch, ChangeDateTime cdt)
        {
            incrementCount = ic;
            getAlarmList = gal;
            addButtonDisabled = abd;
            getBeingEditedValue = gbev;
            hideEditAlarm = hea;    
            setBeingEnabledTrue = sbet;
            getForm1 = gf;
            updateStopTimer = ust;
            updateSnooze = us;
            editing = e;
            changeDateTime = cdt;
            changedCheckbox = cch;
        }

        public Controller SetForm1Controller()
        {
            return this;
        }

        public DateTime CurrentAlarmTime(BindingList<Alarm> alarmList)
        {
            changeDateTime(alarmList[_selectedIndex].Time);
            return alarmList[_selectedIndex].Time;
        }

        public bool CurrentChecked(BindingList<Alarm> alarmList)
        {
            changedCheckbox(alarmList[_selectedIndex].Checked);
            return alarmList[_selectedIndex].Checked;
        }

        public void SetSounds(Sound sound)
        {
            switch (sound)
            {
                case Sound.Radar:
                    _alarmSound = "Radar";
                    break;
                case Sound.Beacon:
                    _alarmSound = "Beacon";
                    break;
                case Sound.Circuit:
                    _alarmSound = "Circuit";
                    break;
                case Sound.Chimes:
                    _alarmSound = "Chimes";
                    break;
                case Sound.Reflection:
                    _alarmSound = "Reflection";
                    break;
                default:
                    _alarmSound = "No Sound";
                    break;
            }
        }

        public void ReadFileHelper()
        {
            if (File.Exists("..\\..\\Alarms.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\Alarms.txt");
                while (!sr.EndOfStream)
                {
                    string readLine = sr.ReadLine();
                    if (readLine == "")
                    {
                        break;
                    }
                    string[] alarmData = readLine.Split(',');
                    AddListItemHelper(Convert.ToDateTime(alarmData[0]), Convert.ToBoolean(alarmData[1]), alarmData[2]);
                    incrementCount();
                }
                AddButtonDisabledHeper();
                sr.Close();
            }
        }

        public void AddListItemHelper(DateTime time, bool onOff, string alarmSound)
        {
            Alarm alarm = new Alarm();
            alarm.Time = time;
            alarm.Checked = onOff;
            alarm.Sounds = alarmSound;
            BindingList<Alarm> list = getAlarmList();
            list.Add(alarm);
        }

        public void AddButtonDisabledHeper()
        {
            addButtonDisabled();
        }

        public void AddClickHelper()
        {
            EditForm = new AddEditAlarm(false, DateTime.Now);
            EditForm.Show();
        }

        public void SetClickHelper(DateTime timePickerValue, bool alarmStatus, AddEditAlarm ae, BindingList<Alarm> alarmList)
        {
            EditForm = ae;
            if (getBeingEditedValue())
            {
                if (alarmStatus) EditChanges(timePickerValue, true, alarmList, _alarmSound);
                else EditChanges(timePickerValue, false, alarmList, _alarmSound);
            }
            else if (!getBeingEditedValue())
            {
                if (alarmStatus)
                {
                    AddListItemHelper(timePickerValue, true, _alarmSound);
                }
                else if (!alarmStatus)
                {
                    AddListItemHelper(timePickerValue, false, _alarmSound);
                }
            }
            AddToTextFile(alarmList);
            incrementCount();
            addButtonDisabled();
            hideEditAlarm(EditForm);
        }

        public void AddToTextFile(BindingList<Alarm> alarmList)
        {
            if (File.Exists("..\\..\\Alarms.txt"))
            {
                using (StreamWriter sw = new StreamWriter("..\\..\\Alarms.txt"))
                {
                    for (int i = 0; i < alarmList.Count; i++)
                    {
                        sw.WriteLine(alarmList[i].Time.ToString() + "," + alarmList[i].Checked.ToString() + "," + alarmList[i].Sounds);
                    }
                }
            }
        }

        public void EditClickHelper(object selectedItem, int alarmIndex, BindingList<Alarm> alarmList, AddEditAlarm addEdit)
        {
            _selectedIndex = alarmIndex;    
            if (selectedItem != null)
            {
                int index = alarmIndex;
                string[] alarmString = selectedItem.ToString().Split(',');
                alarmList[index].Time = Convert.ToDateTime(alarmString[0]);
                if (alarmString[1] == " ON")
                {
                    alarmList[index].Checked = true;
                }
                else
                {
                    alarmList[index].Checked = false;
                }
                CurrentAlarmTime(alarmList);
                CurrentChecked(alarmList);
                setBeingEnabledTrue();
                addEdit.Show();
            }
            alarmList.ResetBindings();
        }

        public void EditChanges(DateTime dateTime, bool onOff, BindingList<Alarm> alarmList, string alarmSound)
        {
            int loopCounter = 0;
            foreach (Alarm a in alarmList)
            {
                if (loopCounter == _selectedIndex)
                {
                    alarmList[loopCounter].Time = dateTime;
                    alarmList[loopCounter].Checked = onOff;
                    alarmList[loopCounter].Sounds = alarmSound;
                    alarmList.ResetBindings();
                    editing(false);
                    break;
                }
                loopCounter++;
            }
        }
        public void StopClickHelper(BindingList<Alarm> alarmList)
        {
            foreach(Alarm a in alarmList)
            {
                if (a.Stopped)
                {
                    EditChanges(a.Time, a.Checked, alarmList, a.Sounds);
                    MessageBox.Show("Your alarm was stopped!");
                    a.Checked = false;
                    string[] alarmString = a.ToString().Split(',');
                    a.Time = Convert.ToDateTime(alarmString[0]);
                    alarmString[1] = " OFF";
                    alarmList.ResetBindings();
                    a.Stopped = false;
                }
            }
            AddToTextFile(alarmList);
        }

        public void CheckAlarmsHelper(BindingList<Alarm> alarmList)
        {
            DateTime current = DateTime.Now;
            if (alarmList.Count > 0)
            {
                foreach (Alarm alarm in alarmList)
                {
                    if (alarm != null)
                    {
                        if (!alarm.Stopped)
                        {
                            if (alarm.Checked && current.Hour == alarm.Time.Hour && current.Minute == alarm.Time.Minute)
                            {
                                updateStopTimer(alarm);
                            }
                        }
                    }
                }
            }
        }

        public void SnoozeHelper(BindingList<Alarm> alarmList)
        {
            if (alarmList.Count > 0)
            {
                foreach (Alarm alarm in alarmList)
                {
                    if (alarm != null)
                    {
                        if (alarm.Snoozed)
                        {
                            updateSnooze(alarm);
                        }
                    }
                }
            }
        }

        public void CheckSnoozed(BindingList<Alarm> alarmList)
        {
            DateTime current = DateTime.Now;
            foreach(Alarm a in alarmList)
            {
                if(a.Checked && current.Hour == a.Time.Hour && current.Minute == a.Time.Minute)
                {
                    a.Snoozed = true;
                }
            }
        }
    }
}