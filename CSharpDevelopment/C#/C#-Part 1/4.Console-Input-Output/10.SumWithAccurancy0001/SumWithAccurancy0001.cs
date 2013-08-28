using System;

class SumWithAccurancy0001
{
    static void Main()
    {
        double sum = 1;

        for (int i = 2, j = 3; 1.0 / i > 0.001; i += 2, j += 2)
        {
            float numerator = 1f;
            float a = numerator / i;
            float b = numerator / j;
            sum = sum + a - b;
        }
        Console.WriteLine("{0:F3}",sum);
    }
}