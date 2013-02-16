using System;

class GreaterNumberExchangesVar
{
    static void Main()
    {
        Console.Write("Въведи първото число: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи второто число: ");
        int second = Convert.ToInt32(Console.ReadLine());

        if (first > second)
        {
            int middle = first;
            first = second;
            second = middle;
            Console.WriteLine("First number {0} is greater than second {1}.\n Exchange variables! - Done!", first, second);
        }
        else
        {
            Console.WriteLine("Second number {0} is greater than first {1}.", second, first);
        }
    }
}