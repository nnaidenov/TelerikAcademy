using System;

class GCD
{
    static void Main()
    {
        Console.Write("Въведи а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int divider = b;
        int delitel = a;
        int firstStep = delitel / divider;
        int firstStep2 = firstStep * divider;
        int finalStep = delitel - firstStep2;
        int biggestDivider = 0;

        for (int i = 0; finalStep !=0 ; i++)
        {
            firstStep = delitel / divider;
            firstStep2 = firstStep * divider;
            finalStep = delitel - firstStep2;
            delitel = divider;
            biggestDivider = divider;
            divider = finalStep;
            Console.WriteLine(finalStep);
        }
        Console.WriteLine();
        Console.WriteLine("GCD is: {0}",biggestDivider);
    }
}