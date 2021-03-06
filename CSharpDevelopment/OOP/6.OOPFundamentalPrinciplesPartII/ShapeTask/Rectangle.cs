﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) 
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
