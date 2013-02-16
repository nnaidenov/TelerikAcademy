using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1 };
        int maxSeq = 0;
        int finalElement =0;
        int seq = 1;
        int curElement = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                seq++;
                curElement = array[i];
            }
            else
            {
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                    finalElement = array[i];
                }
                seq = 1;
            }
        }

        //Print Result
        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write("{0} ", curElement);
        }
    }
}
