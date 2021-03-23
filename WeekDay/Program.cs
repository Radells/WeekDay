using System;

namespace WeekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine("День недели: " + ((WeekDay)day).DayWeek);
            }
            Console.Read();
        }
    }
}
