using System;

namespace IsYearLeap
{
    class IsYearLeap
    {
        static void Main(string[] args)
        {
            bool isLeap = DateTime.IsLeapYear(2013);
            if (isLeap)
            {
                Console.WriteLine("Is Leap!");
            }
            else
            {
                Console.WriteLine("Not Leap!");
            }
        }
    }
}
