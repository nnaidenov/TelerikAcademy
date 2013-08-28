using System;

namespace ReverseDigitOfGivenNumber
{
    class ReverseDigitOfGivenNumber
    {
        static void Main()
        {
            int givenNumber = 256;

            int reversNumber = ReversDigitOfNumber(givenNumber);
            Console.WriteLine(reversNumber);
        }

        private static int ReversDigitOfNumber(int givenNumber)
        {
            string digits = Convert.ToString(givenNumber);
            int[] reversedDigits = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                reversedDigits[i] = digits[i] - 48;
            }

            //Make digits one Real Decimal Number
            int newInt = 0;
            for (int i = reversedDigits.Length-1; i >= 0; i--)
            {
                int possitinInt = (int)Math.Pow(10, i) * reversedDigits[i];
                newInt += possitinInt;
            }
            return newInt;
        }
    }
}
