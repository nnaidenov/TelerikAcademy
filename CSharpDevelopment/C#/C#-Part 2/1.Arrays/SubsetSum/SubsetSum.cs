using System;

class SubsetSum
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int s = 14;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                sum = array[i] + array[j];
                if (sum == s)
                {
                    Console.WriteLine("Yes");
                    break;
                }  
            }
        }
    }
}