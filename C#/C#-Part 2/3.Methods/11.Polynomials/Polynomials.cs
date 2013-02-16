using System;

namespace Polynomials
{
    class Polynomials
    {
        static void Main()
        {
            int[] firstPol = new int[3];
            int[] secondPol = new int[3];

            AddFirstPolynomials(0, -1, 5, firstPol);
            AddSecondPolynomials(6, -5, 10, secondPol);
            PrintPolynomials(firstPol, secondPol);
            Console.WriteLine();
            SumPolynomials(firstPol, secondPol);
            SubtractionPolynomials(firstPol, secondPol);
        }

        private static void SumPolynomials(int[] firstPol, int[] secondPol)
        {
            int[] sum = new int[3];
            for (int i = 0; i < firstPol.Length; i++)
            {
                sum[i] = firstPol[i] + secondPol[i];
            }
            Console.WriteLine("Sum: {0}X^2 + {1}X + {2}", sum[2], sum[1], sum[0]);
        }

        private static void SubtractionPolynomials(int[] firstPol, int[] secondPol)
        {
            int[] subtraction = new int[3];
            for (int i = 0; i < firstPol.Length; i++)
            {
                subtraction[i] = firstPol[i]-secondPol[i];
            }
            Console.WriteLine("Substraction: {0}X^2 + {1}X + {2}", subtraction[2], subtraction[1], subtraction[0]);
        }

        private static void PrintPolynomials(int[] firstPol, int[] secondPol)
        {
            Console.WriteLine("{0}X^2 + {1}X + {2}", firstPol[2], firstPol[1], firstPol[0]);
            Console.WriteLine("{0}X^2 + {1}X + {2}", secondPol[2], secondPol[1], secondPol[0]);
        }

        private static void AddFirstPolynomials(int a, int b, int c, int[] firstPol)
        {
            firstPol[0] = c;
            firstPol[1] = b;
            firstPol[2] = a;
        }

        private static void AddSecondPolynomials(int a, int b, int c, int[] secondPol)
        {
            secondPol[0] = c;
            secondPol[1] = b;
            secondPol[2] = a;
        }
    }
}
