using System;
using System.Collections.Generic;

namespace AddsTwoNumbersRepresentedAsArrays
{
    class AddsTwoNumbersRepresentedAsArrays
    {
        static void Main()
        {
            List<int> sum = new List<int>();
            ulong a = 2355445281328542484;
            ulong b = 365585257812185782;
            Console.WriteLine(a+b);
            bool moreThanTen = false;
            ulong biggestInt = Math.Max(a, b);
            ulong smallesttInt = Math.Min(a, b);

            string bigNumberString = Convert.ToString(biggestInt);
            string smallNumberString = Convert.ToString(smallesttInt).PadLeft(bigNumberString.Length, '0');

            int[,] singleDigits = new int[2, bigNumberString.Length];


            for (int col = 0; col < bigNumberString.Length; col++)
            {
                singleDigits[0, col] = bigNumberString[col] - 48;
            }

            for (int col = 0; col < smallNumberString.Length; col++)
            {
                singleDigits[1, col] = smallNumberString[col] - 48;
            }
            int curSum = 0;
            for (int i = bigNumberString.Length-1; i >= 0; i--)
            {
                curSum = singleDigits[0, i] + singleDigits[1, i];
                if (moreThanTen)
                {
                    curSum += 1;
                }

                if (curSum >= 10)
                {
                    string overFlow = Convert.ToString(curSum);
                    int dec = Convert.ToInt32(overFlow[1]-48);
                    sum.Add(dec);
                    moreThanTen = true;

                }
                else
                {
                    sum.Add(curSum);
                    moreThanTen = false;
                }
            }
            if (moreThanTen)
            {
                sum.Add(1);
            }

            for (int i = sum.Count-1; i >= 0; i--)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
        }
    }
}
