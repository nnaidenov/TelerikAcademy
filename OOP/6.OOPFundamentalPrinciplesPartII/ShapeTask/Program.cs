using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Circle(5), 
                new Rectangle(2, 3), 
                new Triangle(5, 2),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
