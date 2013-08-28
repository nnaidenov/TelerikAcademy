using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod
{
    class MathMethod
    {
        static void Main()
        {
            int howMany = int.Parse(Console.ReadLine());
            decimal[] numbers = new decimal[howMany];

            Console.WriteLine();

            FillArray(numbers);
            SortArray(numbers);
            FindMin(numbers);
            FindMax(numbers);
            FindAverage(numbers);
            FindSum(numbers);
            FindProduct(numbers);
        }

        private static void FindProduct(params decimal[] numbers)
        {
            decimal product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine("Product: " + product);
        }

        private static void FindSum(params decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum: " + sum);
        }

        private static void FindAverage(params decimal[] numbers)
        {
            Console.WriteLine("Average: " + numbers[numbers.Length/2]);
        }

        private static void FindMax(params decimal[] numbers)
        {
            Console.WriteLine("Max: " + numbers[numbers.Length-1]);
        }

        private static void FindMin(params decimal[] numbers)
        {
            Console.WriteLine("Min: " + numbers[0]);
        }

        private static void SortArray(params decimal[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        decimal swap = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = swap;
                    }
                }
            }
        }

        private static void FillArray(decimal[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = decimal.Parse(Console.ReadLine());
            }
        }
    }
}
