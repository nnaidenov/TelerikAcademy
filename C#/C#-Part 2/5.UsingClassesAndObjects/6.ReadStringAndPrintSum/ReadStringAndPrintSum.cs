using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadStringAndPrintSum
{
    class ReadStringAndPrintSum
    {
        static void Main()
        {
            string numbers = "43 68 9 23 318";

            int sum = 0;
            string[] array = numbers.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i].Trim());
            }
            Console.WriteLine(sum);
        }
    }
}
