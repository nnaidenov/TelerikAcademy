using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePaths(Path path)
        {
            string pathWrite = @"../../Paths.txt";
            StreamWriter writer = new StreamWriter(pathWrite);

            using (writer)
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
                writer.Flush();
            }
        }

        public static List<Path> ReadPaths()
        {
            Path readPaths = new Path();
            List<Path> pathsLoaded = new List<Path>();
            string pathRead = @"../../Paths.txt";
            StreamReader reader = new StreamReader(pathRead);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Structure3D point = new Structure3D();
                    string[] points = line.Split(',');
                    point.PositionX = int.Parse(points[0]);
                    point.PositionY = int.Parse(points[1]);
                    point.PositionZ = int.Parse(points[2]);
                    readPaths.AddPoint(point);
                }
                line = reader.ReadLine();
            }
            return pathsLoaded;
        }
    }
}
