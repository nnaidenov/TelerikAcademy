using System;
using System.IO;

namespace ReadTextFileInsertsLineNumbersWrittenOtherFile
{
    class ReadTextFileInsertsLineNumbersWrittenOtherFile
    {
        static void Main()
        {
            string pathRead = @"../../WithoutLines.txt";
            string pathWrite = @"../../WithLines.txt";
            StreamReader reader = new StreamReader(pathRead);
            StreamWriter writer = new StreamWriter(pathWrite);

            using (reader)
            {
                int lines = 0;
                string singleLine = reader.ReadLine();

                while(singleLine != null)
                {
                    lines++;
                    writer.WriteLine("Line {0}: {1}", lines, singleLine);
                    singleLine = reader.ReadLine();
                }
                writer.Flush();
            }
        }
    }
}
