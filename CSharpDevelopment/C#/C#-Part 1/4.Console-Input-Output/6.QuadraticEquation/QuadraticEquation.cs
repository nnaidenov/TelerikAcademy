using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Въведете а: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Въведете b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Въведете c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double d = (b * b) - (4 * (a) * (c));
        double dSqrt = Math.Sqrt(d);
        if (d > 0)
        {
            double x1 = (-(b)+dSqrt)/2*a;
            double x2 = (-(b) - dSqrt) / 2*a;
            Console.WriteLine("Дискриминантата е положителна.");
            Console.WriteLine("Корените на уравнението са X1={0:F2} и X2={1:F2}", x1, x2);
        }
        else if(d == 0)
        {
            double x = (-(b)) / 2 * a;
            Console.WriteLine("Дискриминантата е равна на 0.");
            Console.WriteLine("Уравнението има корен X1,2= {0:F2}", x);
        }
        else
        {
            Console.WriteLine("Уравнението няма реални корени.");
        }
    }
}