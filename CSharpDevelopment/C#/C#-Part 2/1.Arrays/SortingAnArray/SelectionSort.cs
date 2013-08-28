using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 2, 1, -6, 3, -5, 0, 12};
        int smallest = int.MaxValue;

        // Pring Array UnSort
        foreach (var a in array)
        {
            Console.Write ("{0} ", a);
        }

        // Sort Array
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
        Console.WriteLine();

        // Print SortArray
        foreach (var a in array)
        {
            Console.Write("{0} ", a);
        }
    }
}