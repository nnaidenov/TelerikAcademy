using System;

class PrintFirst10Members
{
    static void Main()
    {
        for (int i = 2; i <= 10; i= i + 2 )
        {
            Console.Write(" " + i);
            Console.Write(" " + -(i+1));
        }
        Console.WriteLine();
    }
}