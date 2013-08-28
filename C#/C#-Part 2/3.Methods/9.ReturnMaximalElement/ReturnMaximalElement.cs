using System;

namespace ReturnMaximalElement
{
    class ReturnMaximalElement
    {
        static void Main()
        {
            int[] array = { 4, 1, 2, 12, 3, 0, 5, 9, 8, 10 };
           // int index = 3;

            //SortArrayAsc(array, index);
            //SortArrayDesc(array, index);
            SortArrayAsc(array);
            SortArrayDesc(array);
        }

        private static void SortArrayDesc(int[] array, int index = 0)
        {
            for (int i = index; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        private static void SortArrayAsc(int[] array, int index = 0)
        {
            for (int i = index; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
