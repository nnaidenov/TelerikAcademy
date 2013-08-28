using System;

class GeneratesAllTheCombinationsOfKandN
{
    static void Main()
    {
        int n = 5;
        int k = 2;

        int[] array = new int[k];
        Variations(array, 0, n, 1);//Call Method
    }

    static void Variations(int[] array, int index, int n, int k)
    {
        if (index == array.Length)//Bottom
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = k; j <= n; j++)//Call Recusion
            {
                array[index] = j;
                Variations(array, index + 1,n, j+1);
            }
        }
    }
}