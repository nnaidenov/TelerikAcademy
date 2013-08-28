using System;

class SumOfSomeSubsetOfThemIs0
{
    static void Main()
    {
        Console.Write("Въведи първото число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи второто число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи третото число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи четвъртото число: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи петото число: ");
        int e = Convert.ToInt32(Console.ReadLine());


        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        }


        else if (b + c + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1|, {2}, {3}", b, c, d, e);
        }
        else if (a + c + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2}, {3} ", a, c, d, e);
        }
        else if (a + b + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2}, {3} ", a, b, d, e);
        }
        else if (a + b + c + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2}, {3} ", a, b, c, e);
        }
        else if (a + b + c + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2}, {3} ", a, b, c, d);
        }


        else if (c + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", c, d, e);
        }
        else if (b + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", b, d, e);
        }
        else if (a + d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, d, e);
        }
        else if (b + c + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", b, c, e);
        }
        else if (a + c + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, c, e);
        }
        else if (a + b + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, b, e);
        }
        else if (b + c + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", b, c, d);
        }
        else if (a + c + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, c, d);
        }
        else if (a + b + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, b, d);
        }
        else if (a + b + c == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1}, {2} ", a, b, c);
        }


        else if (d + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", d, e);
        }
        else if (c + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", c, e);
        }
        else if (b + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", b, e);
        }
        else if (a + e == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", a, e);
        }
        else if (c + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", c, d);
        }
        else if (b + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", b, d);
        }
        else if (a + d == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", a, d);
        }
        else if (b + c == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", b, c);
        }
        else if (a + c == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", a, c);
        }
        else if (a + b == 0)
        {
            Console.WriteLine("Числата чиито сбор е нула са: {0}, {1} ", a, b);
        }
        else
        {
            Console.WriteLine("За съжаление няма комбинация от числа чиито сбор е нула.");
        }
    }
}