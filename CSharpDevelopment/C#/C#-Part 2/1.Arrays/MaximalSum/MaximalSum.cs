using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        // Fill Array
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 0, 12, 1, 1, 3, 0, 5, 6 };

        int curSum = 0;
        int maxSum = 0;

        for (int i = 0; i <= array.Length - k; i++)
        {
            // Sum K numbers
            for (int j = i; j < k + i; j++)
            {
                curSum += array[j];
                Console.Write("{0} ", array[j]);
                if (curSum > maxSum) // Change MaxSum
                {
                    maxSum = curSum;
                }
            }
            Console.Write("= {0}", curSum);
            curSum = 0;
            Console.WriteLine();
        }

        //Print MaxSUm
        Console.WriteLine("MaxSum = {0}",maxSum);
    }
}
