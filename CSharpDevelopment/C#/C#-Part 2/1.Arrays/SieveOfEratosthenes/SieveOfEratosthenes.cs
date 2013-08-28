using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = 100;
        bool[] finalNum = new bool[n];

        //Fill array with TRUE
        for (int i = 2; i < n; i++)
        {
            finalNum[i] = true;
        }

        for (int i = 0; i < Math.Sqrt(n); i++)
        {
            if (finalNum[i] == true)
            {
                for (int j = i*i; j < n; j = j+i)//Put False
                {
                    finalNum[j] = false;
                }
            }
        }

        //Print Numbers
        for (int i = 2; i < n; i++)
        {
            if (finalNum[i] == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}
