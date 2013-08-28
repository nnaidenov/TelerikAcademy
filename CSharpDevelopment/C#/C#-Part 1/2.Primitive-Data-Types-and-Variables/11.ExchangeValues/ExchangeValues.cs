using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("A is: {0}\nB is: {1}", a, b);
    }
}