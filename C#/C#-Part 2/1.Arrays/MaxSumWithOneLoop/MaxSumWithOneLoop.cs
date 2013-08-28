using System;

class MaxSumWithOneLoop
{
    static void Main()
    {
        int[] array = { 0, 12, 1, 1, 3, 0, 5, 6 };
        int end = 0;
        int sum=0;
        int maxSum = 0;
        int steps = 0;
        int realSteps = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

            if (sum > 0)
            {
                steps++;
            }
            else
            {
                sum = 0;
                steps = 0;
            }

            //Change MaxSum
            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
                realSteps = steps;
            }
            
        }

        //Print MaxSum Seq
        for (int i = end - realSteps+1; i <= end; i++)
        {
            Console.Write(" " + array[i]);
        }

        Console.WriteLine();
        //Print MaxSum
        Console.WriteLine("Sum = " + maxSum);
    }
}