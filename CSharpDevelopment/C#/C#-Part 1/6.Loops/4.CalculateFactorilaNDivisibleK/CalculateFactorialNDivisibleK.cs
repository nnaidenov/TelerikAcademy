using System;

class CalculateFactorialNDivisibleK
{
    static void Main()
    {
        Console.Write("Въведи число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи число K: ");
        int numberK = Convert.ToInt32(Console.ReadLine());
        double factorialN = 1;
        double factorialK = 1;

        if (1 < numberN && numberN < numberK)
        {
            for (int i = 1; i <= numberN; i++)
            {
                factorialN *= i;
            }
            Console.WriteLine(factorialN);
            for (int i = 1; i <= numberK; i++)
            {
                factorialK *= i;
            }
            Console.WriteLine(factorialK);
        }
        else 
        {
            Console.WriteLine("N трябва да е по-малко от K!");
        }
        double result = factorialN / factorialK;
        Console.WriteLine(result);
    }
}