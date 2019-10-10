using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Email_Client
{
    public class Clock
    {
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;

        public delegate void TimeChangeHandler(object sender, TimeEventsArgs e);
        public event TimeChangeHandler TimeChanged;

        public void RunClock()
        {
            Thread.Sleep(5000);
            while(true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;
                if(currentTime.Second != this.second)
                {
                    TimeEventsArgs timeEventsArgs = new TimeEventsArgs()
                    {
                        Year = currentTime.Year,
                        Month = currentTime.Month,
                        Day = currentTime.Day,
                        Hour = currentTime.Hour,
                        Second = currentTime.Second,
                        Minute = currentTime.Minute
                    };

                    if(TimeChanged == null)
                    {
                        TimeChanged(this, timeEventsArgs);
                    }
                    this.year = currentTime.Year;
                    this.month = currentTime.Month;
                    this.day = currentTime.Day;
                    this.hour = currentTime.Hour;
                    this.minute = currentTime.Minute;
                    this.second = currentTime.Second;
                }
                
            }
        }
    }
}
