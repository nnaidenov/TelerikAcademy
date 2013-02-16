using System;
using System.Collections.Generic;

namespace HowManyTimesAppear
{
    class HowManyTimesAppear
    {
        static void Main()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 1, 1, 2, 1, 9, 3, 4, 4, 4 };
            int givenNumber = 3;

            CountEqualNumbers(array, givenNumber);
        }

        static void CountEqualNumbers(int[] array, int givenNumber)
        {
            int times = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (givenNumber == array[i])
                {
                    times++;
                }
            }
            Console.WriteLine(times);
        }
    }
}