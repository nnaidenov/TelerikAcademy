using System;

class binarySearch
{
    static void Main()
    {
        int[] array = { -1, 5, 18, 6, 19, 25, 12, 78, 122, 114 };
        int smallest = int.MaxValue;
        int serchingNum = int.Parse(Console.ReadLine());
        foreach (var a in array)
        {
            Console.Write("{0} ", a);
        }
        Console.WriteLine();

        // Sorting Array
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < smallest)
                {
                    smallest = array[j];
                    array[j] = array[i];
                    array[i] = smallest;
                }
            }
            smallest = int.MaxValue;
        }

        foreach (var a in array)
        {
            Console.Write("{0} ", a);
        }

        int start = 0;
        int end = array.Length - 1;
        int middle = 0;

        Console.WriteLine();

        // Start Serching
        while (start <= end)
        {
            middle = (start + end) / 2;
            if (array[middle] == serchingNum)
            {
                Console.WriteLine("Position = " + middle);
                break;
            }
            if (array[middle] < serchingNum)
            {
                start = middle + 1;
            }
            if (array[middle] > serchingNum)
            {
                end = middle - 1;
            }
        }
    }
}
