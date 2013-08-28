using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDaysBetweenTwoDates
{
    class WorkDaysBetweenTwoDates
    {
        static void Main()
        {
            DateTime[] holidays = 
            {
                new DateTime(2013, 1, 1),
                new DateTime(2013, 1, 2),
                new DateTime(2013, 3, 3),
                new DateTime(2013, 5, 1),
                new DateTime(2013, 5, 24),
                new DateTime(2013, 9, 6),
                new DateTime(2013, 9, 22),
                new DateTime(2013, 11, 1),
                new DateTime(2013, 12, 24),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26)
            };

            int day = 5;
            int month = 3;
            int year = 2013;

            DateTime startDay = DateTime.Today;
            Console.WriteLine("Start Day: " + startDay);
            DateTime finish = new DateTime(year, month, day);
            Console.WriteLine("Finish Day: " + finish);

            int length = (finish - startDay).Days;
            Console.WriteLine(length + " days left");

            CheckWorkDays(length, startDay, holidays);
                
        }

        private static void CheckWorkDays(int length, DateTime startDay, DateTime[] holidays)
        {
            int workDays = 0;
            bool isHoliday = false;

            for (int days = 0; days < length; days++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int hDays = 0; hDays < holidays.Length; hDays++)
                    {
                        if (startDay == holidays[hDays])
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        workDays++;
                    }
                    isHoliday = false;
                }
            }
            Console.WriteLine(workDays + " days are workDays");
        }
    }
}
