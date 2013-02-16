using System;

class CheckPointBelongToCircle
{
    static void Main()
    {
        Console.Write("Въведете стойности за X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Въведете стойности за Y: ");
        int y = int.Parse(Console.ReadLine());
        int r = 5;

        bool inCircle = (x * x + y * y) <= r * r;
        if (inCircle == true)
        {
            Console.WriteLine("Точките X и Y са в окръжността!");
        }
        else
        {
            Console.WriteLine("Точките X и Y не са в окръжността!");
        }
    }
}