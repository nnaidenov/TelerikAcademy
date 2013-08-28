using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Menu();
            Console.Write("Enter code: ");
            int press = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (press != 0)
            {

                if (press == 1)
                {
                    Console.Write("Enter Positive Number: ");
                    string digits = Console.ReadLine();
                    int revers = ReversDigitOfNumber(digits);
                    if (revers == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(revers);
                    }
                    Console.WriteLine();
                }
                else if (press == 2)
                {
                    Console.Write("How many Numbers You Enter: ");
                    int howMany = int.Parse(Console.ReadLine());
                    int answer = Average(howMany);
                    if (answer == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(answer);
                    }
                    Console.WriteLine();
                }
                else if (press == 3)
                {
                    decimal answer = SolvesLinearEquation();
                    Console.WriteLine("X= {0}", answer);
                }

                Console.Write("Enter code: ");
                press = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            
        }

        private static decimal SolvesLinearEquation()
        {
            Console.Write("Enter a: ");
            decimal a = decimal.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Enter a != 0");
                Console.WriteLine();
                Console.Write("Enter a: ");
                a = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Enter b: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}X + {1} = 0", a, b);
            decimal answer = -b / a;
            return answer;
        }

        private static int Average(int howMany)
        {
            if (howMany > 0)
            {
                int sum = 0;
                Console.WriteLine("Enter the only One Number in singleLine!");
                for (int index = 0; index < howMany; index++)
                {
                    sum += int.Parse(Console.ReadLine());
                }
                return sum / howMany;
            }
            else
            {
                Console.WriteLine("Pleas Enter more elements of Seq!");
                return 0;
            }
        }

        private static int ReversDigitOfNumber(string givenNumber)
        {
            if (int.Parse(givenNumber) >= 0)
            {
                int[] reversedDigits = new int[givenNumber.Length];

                for (int i = 0; i < givenNumber.Length; i++)
                {
                    reversedDigits[i] = givenNumber[i] - 48;
                }

                //Make digits one Real Decimal Number
                int newInt = 0;
                for (int i = reversedDigits.Length - 1; i >= 0; i--)
                {
                    int possitinInt = (int)Math.Pow(10, i) * reversedDigits[i];
                    newInt += possitinInt;
                }
                return newInt;
            }
            else
            {
                Console.WriteLine("The Number is Negative!");
                return 0;
            }

            
        }

        private static void Menu()
        {
            Console.WriteLine("(1) Reverses the digits of a number (Press 1)");
            Console.WriteLine("(2) Calculates the average of a sequence of integers (Press 2)");
            Console.WriteLine("(3) Solves a linear equation a * x + b = 0 (Press 3)");
            Console.WriteLine("(0) Exit (Press 0)");
            Console.WriteLine();
        }
    }
}