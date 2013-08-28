using System;
using System.Collections.Generic;

class BinSerch
{
    static void Main()
    {
        int k = 32;
        int[] array = { -1, 5, 18, 6, 19, 25, 12, 78, 122, 114 };

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        Array.Sort(array);
        
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        if (~(Array.BinarySearch(array, k)) < 0)
        {
            Console.WriteLine(k);
        }
        if (~(Array.BinarySearch(array, k)) > 0)
        {
            Console.WriteLine(array[~(Array.BinarySearch(array, k))-1]);
        }
    }
}