using System;

class PrintsNumbersInInterval
{
    static void Main()
    {
        Console.Write("Въведете число за край на интервала: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}