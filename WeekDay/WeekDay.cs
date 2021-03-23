using System;
using System.Collections.Generic;
using System.Text;

namespace WeekDay
{
    class WeekDay
    {
        private string _dayWeek;
        public string DayWeek
        {
            get
            {
                return _dayWeek;
            }
            set
            {
                _dayWeek = value;
            }
        }
        public WeekDay(string day)
        {
            this._dayWeek = day;
        }
    }
}
