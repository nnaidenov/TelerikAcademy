using System;

class CalculateNAndKFactorials
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
            for (int i = 1; i <= numberK; i++)
            {
                factorialK *= i;
            }

            int newNumber = numberK - numberN;
            int newFactorial = 1;
            for (int i = 1; i <= newNumber; i++)
            {
                newFactorial *= i;
            }
            double result = (factorialN * factorialK) / newFactorial;
            Console.WriteLine(factorialN + " - N!");
            Console.WriteLine(factorialK + " - K!");
            Console.WriteLine(newFactorial + " - New!");
            Console.WriteLine(result + " - result");
        }
        else
        {
            Console.WriteLine("N трябва да е по-малко от K!");
        }
    }
}