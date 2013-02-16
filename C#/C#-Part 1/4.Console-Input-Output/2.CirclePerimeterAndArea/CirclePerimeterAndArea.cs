using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Въведете радиус: ");
        int r = Convert.ToInt32(Console.ReadLine());

        double circleArea = Math.PI * r * r;
        double circlePerim = 2 * Math.PI * r; 
        Console.WriteLine("Площта на окръжността е: {0}", circleArea);
        Console.WriteLine("Периметъра на окръжността е: {0}", circlePerim);
    }
}