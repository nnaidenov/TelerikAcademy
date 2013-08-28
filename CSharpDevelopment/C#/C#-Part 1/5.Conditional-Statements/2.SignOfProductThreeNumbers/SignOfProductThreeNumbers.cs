using System;

class SignOfProductThreeNumbers
{
    static void Main()
    {
        Console.Write("Въведи първото число: ");
        decimal a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Въведи второто число: ");
        decimal b = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Въведи третото число: ");
        decimal c = Convert.ToDecimal(Console.ReadLine());


        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Знакът след умножение ще е +");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Знакът след умножение ще е +");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Знакът след умножение ще е +");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Знакът след умножение ще е +");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Знакът след умножение ще е -");
        }

        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Знакът след умножение ще е -");
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Знакът след умножение ще е -");
        }

        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Знакът след умножение ще е -");
        }
 
    }
}