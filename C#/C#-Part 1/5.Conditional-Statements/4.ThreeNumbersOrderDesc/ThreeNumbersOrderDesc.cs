using System;

class ThreeNumbersOrderDesc
{
    static void Main()
    {
        int a = 8;
        int b = 7;
        int c = 6;

        if (a > b && b > c)
        {
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }
        else if (a > b && b < c)
        {
            Console.WriteLine("{0},{1},{2}", a, c, b);
        }
        else if (b > a && a > c)
        {
            Console.WriteLine("{0},{1},{2}", b, a, c);
        }
        else if (b > a && a < c)
        {
            Console.WriteLine("{0},{1},{2}", b, c, a);
        }
        else if (c > a && a > b)
        {
            Console.WriteLine("{0},{1},{2}", c, a, b);
        }
        else if (c > a && a < b)
        {
            Console.WriteLine("{0},{1},{2}", c, b, a);
        }
    }
}