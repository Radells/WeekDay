using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WeekDay
{
    class AllDayWeek : IEnumerator
    {
        //2)	Необходимо создать класс, который будет реализовывать интерфейс IEnumerator, +
        //данный класс должен иметь массив объектов дней недели, где каждый объект имеет своё имя, 
        //соответствующие реальному дню недели, а также данный класс должен уметь возвращать последовательно каждый из объектов массива
        WeekDay[] weekDays;
        int position = -1;
        public AllDayWeek(WeekDay[] days)
        {
            this.weekDays = days;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= weekDays.Length)
                    throw new InvalidOperationException();
                return weekDays[position];
            }
        }

        public bool MoveNext()
        {
            if (position < weekDays.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
