using System;

class CalculatesTrapezoidArea
{
    static void Main()
    {
        Console.Write("Въведете а: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Въведете b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Въведете h: ");
        decimal h = decimal.Parse(Console.ReadLine());

        if ((a >= 0) && (b >= 0) && (h >= 0))
        {
            decimal trapezoidArea = ((a * b)/2) * h;
            Console.WriteLine("Лицето на тапеца е: {0} кв.см", trapezoidArea);
        }
        else
        {
            Console.WriteLine("Въвели сте некоректни данни!");
        }
    }
}