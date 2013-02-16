using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.HowManyDaysBetweenTwoDates
{
    class HowManyDaysBetweenTwoDates
    {
        static void Main(string[] args)
        {
            string firstDate = "24.02.2006";
            string secondDate = "4.02.2007";
            DateTime date = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dateSec = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date);
            Console.WriteLine(dateSec);
            int left = 0;
            if (date > dateSec)
            {
                left = (date - dateSec).Days;
            }
            else
            {
                left = (dateSec - date).Days;
            }
            Console.WriteLine(left);
        }
    }
}