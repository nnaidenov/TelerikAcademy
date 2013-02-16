using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        BigInteger n1 = 0L;
        BigInteger n2 = 1L;
        BigInteger n;

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i = 2; i <= 100; i++)
        {
            n = n1 + n2;
            n1 = n2;
            n2 = n;
            Console.WriteLine(n);
        }
        
    }
}