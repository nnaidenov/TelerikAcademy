using System;

class Quicksort
{
    static void Main()
    {
        int[] array = { 18, 3, -6, -1, 2, -2, 6, 4, -8, 8 };

        foreach (var a in array)
        {
            Console.Write("{0} ", a);
        }
        Console.WriteLine();

        QuickSort(array, 0, array.Length - 1);

        foreach (var a in array)
        {
            Console.Write("{0} ", a);
        }

        Console.WriteLine();
    }

    public static void QuickSort(int[] elements, int left, int right)
    {
        int l = left;
        int r = right;
        int middle = elements[(left + right) / 2];

        while(l <= r)
        {
            while (elements[l] < middle)
            {
                l++;
            }

            while (elements[r] > middle)
            {
                r--;
            }

            if (l <= r)
            {
                int swap = elements[r];
                elements[r] = elements[l];
                elements[l] = swap;

                l++;
                r--;
            }
        }

        if (left < r)
        {
            QuickSort(elements, left, r);
        }

        if (l < right)
        {
            QuickSort(elements, l, right);
        }
    }
}

