using System;

class CalculatesRectangle_Area
{
    static void Main()
    {
        Console.Write("Задай ширина: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задай височина: ");
        int height = Convert.ToInt32(Console.ReadLine());

        int result = width * height;
        Console.WriteLine("Лицето на правоъгълникът е: {0}", result);
    }
}

