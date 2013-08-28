using System;
using System.Collections.Generic;

namespace AddsTwoNumbersRepresentedAsArrays
{
    class AddsTwoNumbersRepresentedAsArrays
    {
        static void Main()
        {
            List<int> factorial = new List<int>();
            int a = 9;
            int factorialSize = a;
            Console.WriteLine(120);
            int inMind = 0;
            bool moreThan = false;
            factorial.Add(1);

            string bigNumberString = Convert.ToString(a);

            int[,] singleDigits = new int[a, bigNumberString.Length];

            for (int row = 0; row < factorialSize; row++)
            {
                for (int col = 0; col < bigNumberString.Length; col++)
                {
                    singleDigits[row, col] = bigNumberString[col] - 48;
                }
                bigNumberString = Convert.ToString(--a).PadLeft(bigNumberString.Length, '0');
            }

            int curFac = 1;

            while (factorialSize != 0)
            {
                for (int i = bigNumberString.Length - 1; i >= 0; i--)
                {
                    curFac *= singleDigits[factorialSize-1, i];
                }
                factorialSize--;
            }
            Console.WriteLine(curFac);

            //for (int i = factorial.Count - 1; i >= 0; i--)
            //{
            //    Console.Write(factorial[i]);
            //}
            Console.WriteLine();
        }
    }
}
