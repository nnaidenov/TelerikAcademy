using System;
using System.Numerics;

class HowManyZeros
{
    static void Main()
    {
        Console.WriteLine("Въведи N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger m = 1;
        for (int i = 1; i <= n; i++)
        {
            m *= i;
        }
        int result = n / 5;
        Console.WriteLine(m);
        Console.WriteLine("Резултатът съдържа {0} нули.", result);
    }
}