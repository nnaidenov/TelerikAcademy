using System;
using System.IO;

namespace PrintOddLinesFromFile
{
    class PrintOddLinesFromFile
    {
        static void Main()
        {
            string path = @"../../OddLines.txt";
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                int rows = 0;
                string singelLine = reader.ReadLine();

                while (singelLine != null)
                {
                    rows++;
                    if (rows%2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", rows, singelLine);
                        singelLine = reader.ReadLine();
                    }
                    else
                    {
                        singelLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
