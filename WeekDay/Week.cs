using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WeekDay
{
    class Week : IEnumerable
    {
        WeekDay[] weekDays = { new WeekDay("Понедельник"), new WeekDay("Вторник"), new WeekDay("Среда"), new WeekDay("Четверг"), new WeekDay("Пятница"), new WeekDay("Суббота"), new WeekDay("Воскресенье") };
        public IEnumerator GetEnumerator()
        {
            return new AllDayWeek(weekDays);
        }
    }
}
