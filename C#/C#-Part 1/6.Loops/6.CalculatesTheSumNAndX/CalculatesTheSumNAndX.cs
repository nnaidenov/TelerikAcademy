using System;

class CalculatesTheSumNAndX
{
    static void Main()
    {
        Console.Write("Въведи n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.Write("Въвди x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double nFact = 1;
        double xStepen = 1;
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            xStepen *= x;
            sum += (nFact / xStepen);
        }
        Console.WriteLine(sum+1);
    }
}
