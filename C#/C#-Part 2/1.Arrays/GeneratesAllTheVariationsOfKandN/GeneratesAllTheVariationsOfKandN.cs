using System;

class GeneratesAllTheVariationsOfKandN
{
    static void Main()
    {
        int k = 2;
        int n = 3;

        int[] array = new int[k];
        Variations(array, 0, n);
    }

    static void Variations(int[] array, int index, int n)
    {
        if (index == array.Length)//Bottom
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else //Call Recurse
        {
            for (int j = 1; j <= n; j++)
            {
                array[index] = j;
                Variations(array, index + 1, n);
            }
        }
    }
}
