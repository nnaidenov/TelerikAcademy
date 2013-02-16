using System;

class TherthBitIs
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int number = int.Parse(Console.ReadLine());
        int i = 1;
        int numMask = i << 3;
        if ((numMask & number) != 0) 
        {
            Console.WriteLine("Третият бит е: 1");
        }
        else 
        {
            Console.WriteLine("Третият бит е: 0");
        }
    }
}
