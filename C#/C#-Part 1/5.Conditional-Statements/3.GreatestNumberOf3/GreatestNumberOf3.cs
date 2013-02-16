using System;

class GreatestNumberOf3
{
    static void Main()
    {
        int a = 5;
        int b = 6;
        int c = 7;

        if(a>b && b>c)
        {
            Console.WriteLine("a={0} е най-голямото число.",a);
        }
        else if (b > a && a > c)
        {
            Console.WriteLine("b={0} е най-голямото чосло.", b);
        }
        else
        {
            Console.WriteLine("c={0} е най-голямото число.",c);
        }
    }
}