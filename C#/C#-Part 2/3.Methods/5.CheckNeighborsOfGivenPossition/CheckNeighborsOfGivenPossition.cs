using System;

namespace CheckNeighborsOfGivenPossition
{
    class CheckNeighborsOfGivenPossition
    {
        static void Main()
        {
            int[] array = { 4, 1, 2, 12, 3, 0, 5, 9, 8, 10 };
            int givenNumber = 12;

            CheckGivenElementIsBiggerThanNeighbors(array, givenNumber);
        }

        static void CheckGivenElementIsBiggerThanNeighbors(int[] array, int givenNumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (givenNumber == array[i])
                {
                    if (i > 0)
                    {
                        if (givenNumber > array[i-1] && givenNumber > array[i+1])
                        {
                            Console.WriteLine("Ok");
                        }
                        else
                        {
                            Console.WriteLine("Not Ok");
                        }
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("Number have only One Neighbor-Right!");
                        if (givenNumber > array[i+1])
                        {
                            Console.WriteLine("Ok-Right");   
                        }
                        else
                        {
                            Console.WriteLine("Not Ok-Right");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number have only One Neighbor-Left!");
                        if (givenNumber > array[i - 1])
                        {
                            Console.WriteLine("Ok-Left");
                        }
                        else
                        {
                            Console.WriteLine("Not Ok-Left");
                        }
                    }
                }
            }
            
        }
    }
}
