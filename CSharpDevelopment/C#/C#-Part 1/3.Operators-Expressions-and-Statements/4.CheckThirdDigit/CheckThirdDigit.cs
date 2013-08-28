using System;

class CheckThirdDigit
{
    static void Main()
    {
        int a = 1148752;
        int divideAto100 = a / 100;
        int finalDivide = divideAto100 % 10;
        bool finalResult = finalDivide == 7;

        Console.WriteLine("1148752: {0}", finalResult);
    }
}

