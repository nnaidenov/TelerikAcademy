using System;

class MergeSort
{
    static int numOfLoops;
    static int[] array;

    static void Main()
    {
        numOfLoops = 2;
        array = new int[numOfLoops];

        Abc(0);
    }

    static void Abc(int n)
    {
        if (n == numOfLoops)
        {
            PrintAbc();
            return;
        }

        for (int i = 1; i <= numOfLoops; i++)
        {
            array[n] = i;
            Abc(n + 1);
        }
        
    }

    static void PrintAbc()
    {
        for (int i = 0; i < numOfLoops; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
