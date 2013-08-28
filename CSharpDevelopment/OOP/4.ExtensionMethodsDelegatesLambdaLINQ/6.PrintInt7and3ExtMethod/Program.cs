using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PrintInt7and3ExtMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine("---------- LAMBDA ----------");
            var sortLAMBDA = numbers.Where(num => num % 7 == 0 && num % 3 == 0);

            foreach (var number in sortLAMBDA)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("---------- LINQ ----------");
            var sortLINQ = from number in numbers
                          where number % 7 == 0 && number % 3 == 0
                          select number;

            foreach (var number in sortLINQ)
            {
                Console.WriteLine(number);
            }  
        }
    }
}
