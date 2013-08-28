using System;

    class PrintNumberNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Въведи число: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }