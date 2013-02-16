using System;
using System.Collections.Generic;

namespace ReturnIndexOfElement
{
    class ReturnIndexOfElement
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 2, 12, 3, 0, 5, 9, 8, 10 };
            //int[] array = { 1,2,3,4,5 };

           int index = ReturnIndexOfElementInArray(array);
           Console.WriteLine(index);
        }

        static int ReturnIndexOfElementInArray(int[] array)
        {
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i-1] && array[i] > array[i+1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
