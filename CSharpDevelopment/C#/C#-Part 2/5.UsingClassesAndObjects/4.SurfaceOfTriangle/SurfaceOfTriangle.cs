using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int h = 4;
            int sin = 90;
            ABSin(a, b, sin);
            AH(a, h);
            ABC(a, b, c);
        }

        private static void ABC(int a, int b, int c)
        {
            decimal p = (a + b + c) / 2;
            decimal resultUnderSqrt = p * (p - a)*(p - b)*(p - c);
            decimal result = (decimal)Math.Sqrt((double)resultUnderSqrt);
            Console.WriteLine(result);
        }

        private static void AH(int a, int h)
        {
            decimal result = a * h / 2;
            Console.WriteLine(result);
        }

        private static void ABSin(int a, int b, int sin)
        {
            decimal result = (a * b * (decimal)Math.Sin(sin)) / 2;
            Console.WriteLine(result);
        }
    }
}
