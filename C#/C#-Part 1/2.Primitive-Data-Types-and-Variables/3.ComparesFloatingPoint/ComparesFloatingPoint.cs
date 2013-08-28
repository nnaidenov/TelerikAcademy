using System;

class ComparesFloatingPoint
{
    static void Main()
    {
        decimal a = 5.00000001M;
        decimal b = 5.00000002M;
        decimal c = 5.3M;
        decimal d = 6.01M;

        decimal precision = 0.000001M;

        bool compareAandB = (b-a < precision);
        bool compareCandD = (d-c < precision);

        Console.WriteLine("A({0}) and B({1}) are equal with accuracy: {4} - {5} \nC({2}) and D({3}) are equal with accuracy: {4} - {6}",
            a, b, c, d, precision, compareAandB, compareCandD);
    }
}