using System;
using System.IO;

namespace ConcatenateTwoFiles
{
    class ConcatenateTwoFiles
    {
        static void Main()
        {
            string pathOne = @"../../firstFile.txt";
            string pathTwo = @"../../secondFile.txt";
            StreamReader firstFile = new StreamReader(pathOne);
            StreamReader secondFile = new StreamReader(pathTwo);
            StreamWriter writeNewFile = new StreamWriter(@"../../finalFile.txt");

            using(firstFile)
            {
                using (secondFile)
                {
                    string lineFirstText = firstFile.ReadLine();
                    string lineSecondText = secondFile.ReadLine();

                    while (lineFirstText != null)
                    {
                        writeNewFile.WriteLine(lineFirstText);
                        lineFirstText = firstFile.ReadLine();
                    }

                    while (lineSecondText != null)
                    {
                        writeNewFile.WriteLine(lineSecondText);
                        lineSecondText = secondFile.ReadLine();
                    }
                    writeNewFile.Flush();
                }
            }
        }
    }
}
