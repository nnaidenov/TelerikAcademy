using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 0, 3, 1, 1, 3, 0, 5, 6 };

        List<int> newSeq = new List<int>();
        int maxSeq = 0;
        int seq = 1;
        int startSeq = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            // check for New Seq
            if (array[i] < array[i + 1])
            {
                seq++;
                if (seq == 2)
                {
                    startSeq = i;
                }
                if (seq > maxSeq)
                {
                    for (int j = startSeq; j < seq + startSeq; j++)
                    {
                        if (j == startSeq)
                        {
                            newSeq.Clear();
                        }
                        newSeq.Add(array[j]);
                    }
                }
            }
            else // Stop Seq
            {
                if (seq > maxSeq) // Input New Seq
                {
                    for (int j = startSeq; j < seq+startSeq; j++) 
                    {
                        if (j == startSeq)
                        {
                            newSeq.Clear();
                        }
                        newSeq.Add(array[j]);                      
                    }
                    maxSeq = seq;
                    startSeq = 0;
                }
                seq = 1;
            }
        }

        //Print Seq
        foreach (var a in newSeq)
        {
            Console.Write("{0} " ,a);
        }

    }
}
