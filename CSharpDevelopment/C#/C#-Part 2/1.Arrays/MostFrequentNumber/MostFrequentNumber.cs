using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 1, 1, 2, 1, 9, 3, 4, 4, 4 };
        int mostFrN = 0;
        int curFrN = 0;
        int maxTimes = 0;
        int curTimes = 1;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                //Compare two numbers
                if (array[i] == array[j])
                {
                    curTimes++;
                    curFrN = array[i];
                    if (j == array.Length-1)
                    {
                        if (curTimes > maxTimes) //Change MaxTimes
                        {
                            maxTimes = curTimes;
                            mostFrN = curFrN;
                        }
                    }
                }
                else
                {
                    if (curTimes > maxTimes) //Change MaxTimes
                    {
                        maxTimes = curTimes;
                        mostFrN = curFrN;
                    }
                }
            }
            curTimes = 1;
        }

        //Print Number end How Many times
        Console.WriteLine("{0} ({1} times)", mostFrN, maxTimes);
    }
}

