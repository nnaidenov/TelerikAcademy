using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        public static Size GetRotatedSize(Size size, double angleOfRotaed)
        {
            double sinOfAngle = Math.Sin(angleOfRotaed);
            double cosOfAngle = Math.Cos(angleOfRotaed);

            double absoluteSinOfAngle = Math.Abs(sinOfAngle);
            double absoluteCosOfAngle = Math.Abs(cosOfAngle);

            double width = absoluteCosOfAngle * size.Width + absoluteSinOfAngle * size.Height;
            double height = absoluteSinOfAngle * size.Width + absoluteCosOfAngle * size.Height;

            return new Size(width, height);
        }
    }
}

