using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.DateExtract
{
    class DateExtract
    {
        static void Main(string[] args)
        {
            string str = "15.02.2012";

            string pattern = @"[0-9]{1,2}\.[0-9]{2}\.[0-9]{4}";

            Match date = Regex.Match(str, pattern);

            while (date.Success)
            {
                Console.WriteLine(date);
                date = date.NextMatch();
            }
        }
    }
}
