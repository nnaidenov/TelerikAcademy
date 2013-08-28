using System;

class LongestIncreasingSeq
{
    static void Main()
    {
        int[] array = {  6, 1, 4, 3, 0, 3, 6, 4, 5, 6 };
        int min = int.MaxValue;
        int[] seqArray = new int[array.Length];
        int[] index = new int[array.Length];
        int lenght = 1;
        int j = 1;
        int k = 0;

        seqArray[j] = array[0];
        j++;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                if (array[i] < seqArray[j - 1])
                {
                    if (array[i] > seqArray[j-2])
                    {
                        seqArray[j-1] = array[i];

                    } 

                }

            }
            else if (array[i] > array[i - 1])
            {
                seqArray[j] = array[i];
                j++;
                lenght++;
            }
            else if (array[i] == array[i - 1])
            {
                seqArray[j] = array[i];
                j++;
            }
        }

        foreach (var a in array)
        {
            Console.Write(a + " ");
        }

        Console.WriteLine();
        Console.WriteLine(lenght);
        Console.WriteLine();

        for (int i = 1; i < seqArray.Length; i++)
        {
                Console.Write(seqArray[i] + " ");
        }
    }
}