using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Client
{
    public class LabelClock
    {
        private string timeFormat_24h;
        private string timeFormat_12h;
        private string timeZone;
        private int Decrese_by_12;
        public void Subscribe(Clock theclock)
        {
            theclock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }

        private void NewTime(object sender, TimeEventsArgs e)
        {
            if (e.Hour > 11)
            {
                timeZone = "PM";
            }
            else
            {
                timeZone = "AM";
            }
            timeFormat_24h = e.Hour.ToString() + ":" + e.Minute.ToString();
            if(timeZone == "PM" && e.Hour != 12)
            {
                Decrese_by_12 = e.Hour - 12;
            }
            
            timeFormat_12h = Decrese_by_12.ToString() + ":" + e.Minute.ToString() + " " + timeZone;
        }

        public string ChangeTimeFormat()
        {
            return timeFormat_12h;
        }


        public string GetTimeFormat()
        {
            return timeFormat_24h;
        }
    }
}
