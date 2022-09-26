using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_Alarm
{
    public class Alarm
    {
        public DateTime Time { get; set; }  

        public bool Checked { get; set; }       

        public int Index { get; set; }

        public bool Stopped { get; set; } = false;

        public bool Snoozed { get; set; } = false;  

        public string Sounds { get; set; }

        public override string ToString()
        {
            if (Checked)
            {
                return Time.ToString("hh:mm tt") + ", ON" + ", Sound: " + Sounds;
            }
            else
            {
                return Time.ToString("hh:mm tt") + ", OFF" + ", Sound: " + Sounds;
            }
        }
    }
}
