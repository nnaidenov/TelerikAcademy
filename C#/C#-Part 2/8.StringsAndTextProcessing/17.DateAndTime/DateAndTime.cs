using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DateAndTime
{
    class DateAndTime
    {
        static void Main(string[] args)
        {
            string date = "27.02.2006 20:00:35";
            DateTime time = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            
            time = time.AddHours(6.5);
            Console.WriteLine(time);
            Console.WriteLine("{0}", time.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
