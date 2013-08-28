using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class GetMax
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

           int bigger = GetMaxNumber(a, b);
           int biggest = GetMaxNumber(bigger, c);

           Console.WriteLine(biggest);
        }

        static int GetMaxNumber(int first, int second)
        {
            int max = first;
            if (second > max)
            {
                max = second; 
            }
            return max;
        }
    }
}
