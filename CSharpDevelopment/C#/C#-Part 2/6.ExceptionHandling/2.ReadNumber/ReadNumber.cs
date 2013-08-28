using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Number
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }

        private static void ReadNumber(int start, int end)
        {
            int secondNum = 0;
            Console.WriteLine("Enter 10 numbers between 1 and 100. Next number must be bigger than previous");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number < start || number > end)
                    {
                        throw new ArgumentException("The number is up 100 or down 1!");
                    }
                    if (secondNum > number)
                    {
                        throw new ArgumentException("The number is smaller than previous!");
                    }
                    else
                    {
                        secondNum = number;
                    }
                }
                catch (FormatException fe)
                {
                    Console.Error.WriteLine("Error: " + fe.Message);
                    break;
                }
                catch (ArgumentException ae)
                {
                    Console.Error.WriteLine("Error: " + ae.Message);
                    break;
                }
                finally
                {
                    Console.WriteLine("Good Bay.");
                }
            }
        }
    }
}
