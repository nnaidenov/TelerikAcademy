using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int s = 11;
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int curSum = 0;
        bool done = false;
        int times = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                curSum += array[j];
                if (curSum == s) //Compare curSum with S-Sum
                {
                    while (done == false) //BackSteps to StartSeq
                    {
                        int num = array[j--];
                        times++;
                        int zero = s -= num;
                        if (zero == 0)
                        {
                            for (int k = j+1; k <= j+times; k++) //Print Seq
                            {
                                Console.Write("{0} ", array[k]);
                            }
                            done = true;
                        }
                    }
                }
                else if (curSum > s)
                {
                    curSum = 0;
                }
            }
        }
    }
}
