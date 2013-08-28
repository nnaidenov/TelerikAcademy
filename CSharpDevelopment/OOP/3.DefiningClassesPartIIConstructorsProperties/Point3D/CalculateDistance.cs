using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Distance
    {
        public static double CalculateDistance(Structure3D first, Structure3D second)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(first.PositionX - second.PositionX, 2) +
                Math.Pow(first.PositionY - first.PositionY, 2) + Math.Pow(first.PositionZ - first.PositionZ, 2));

            return distance;
        }
    }
}