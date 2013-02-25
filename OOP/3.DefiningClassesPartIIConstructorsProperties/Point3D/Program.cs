using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Structure3D firstPoint = new Structure3D(1, 2, 3);
            Structure3D secondPoint = new Structure3D(0, 8, 1);

            Path firstPath = new Path();
            firstPath.AddPoint(firstPoint);
            firstPath.AddPoint(secondPoint);

            PathStorage.SavePaths(firstPath);
            List<Path> pathList = PathStorage.ReadPaths();
        }
    }
}
