using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    public class Circle : Shape
    {
        public Circle(int radious) 
        {
            this.Width = radious;
            this.Height = radious;
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Height * this.Width);
        }
    }
}
