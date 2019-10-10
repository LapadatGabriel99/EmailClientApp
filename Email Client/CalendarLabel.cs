using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    class CalendarLabel
    {
        private string  YearMontDayFormat;
        public void Subcribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewCalendar);
        }

        private void NewCalendar(object sender,TimeEventsArgs e)
        {
            YearMontDayFormat = e.Month.ToString() + "/" + e.Day.ToString() +
                                "/" + e.Year.ToString();
        } 

        public string GetYMDFormat()
        {
            return YearMontDayFormat;
        }
    }
}
