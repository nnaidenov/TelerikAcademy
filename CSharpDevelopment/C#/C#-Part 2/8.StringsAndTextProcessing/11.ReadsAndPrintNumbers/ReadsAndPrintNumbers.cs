using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsAndPrintNumbers
{
    class ReadsAndPrintNumbers
    {
        static void Main()
        {
            int number = 23;

            string decimalNum = string.Format("{0,15:D}", number);
            string hexadecimalNum = string.Format("{0,15:X}", number);
            string percentageNum = string.Format("{0,15:P}", number);
            string scientificNotationNum = string.Format("{0,15:E}", number);

            Console.WriteLine(decimalNum);
            Console.WriteLine(hexadecimalNum);
            Console.WriteLine(percentageNum);
            Console.WriteLine(scientificNotationNum);
        }
    }
}
