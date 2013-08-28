using System;

class SumOfTheFirstNFibonacci
{
    static void Main()
    {
        Console.Write("Колко числа да събера? ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int b = 1;
        int fibonachi;
        int sum = 0;

        for (int i = 1; i <= n - 3; i++)
        {
            fibonachi = a + b;
            a = b;
            b = fibonachi;
            Console.WriteLine(fibonachi);
            sum += fibonachi;
        }
        Console.WriteLine(sum);
    }
}