using System;
class FindGreatestOfFive
{
    static void Main()
    {
        Console.Write("Input value for a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Input value for b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Input value for c: ");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.Write("Input value for d: ");
        decimal d = decimal.Parse(Console.ReadLine());
        Console.Write("Input value for e: ");
        decimal e = decimal.Parse(Console.ReadLine());

        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            Console.WriteLine("The greatest value is : {0}", a);
        }
        else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
        {
            Console.WriteLine("The greatest value is : {0}", b);
        }
        else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            Console.WriteLine("The greatest value is : {0}", c);
        }
        else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            Console.WriteLine("The greatest value is : {0}", d);
        }
        else
        {
            Console.WriteLine("The greatest value is : {0}", e);
        }
    }
}