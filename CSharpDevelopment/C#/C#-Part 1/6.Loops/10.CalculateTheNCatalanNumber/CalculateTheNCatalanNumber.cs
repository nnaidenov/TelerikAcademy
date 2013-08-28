using System;

class CalculateTheNCatalanNumber
{
    static void Main()
    {
        Console.Write("Въведи N: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double nFact = n;
        double nPlusOne = n+1;
        double nPoTwo = n*2;
        double nResult = 1;
        double nPlusOneResult = 1;
        double nPoTwoResult = 1;

        for (int i = 1; i <= nFact; i++)
        {
            nResult *= i;
        }
        
        for (int i = 1; i <= nPlusOne; i++)
        {
            nPlusOneResult *= i;

        }
        
        for (int i = 1; i <= nPoTwo; i++)
        {
            nPoTwoResult *= i;

        }
        
        double resul = nPoTwoResult / (nPlusOneResult * nResult);
        Console.WriteLine(resul);
    }
}