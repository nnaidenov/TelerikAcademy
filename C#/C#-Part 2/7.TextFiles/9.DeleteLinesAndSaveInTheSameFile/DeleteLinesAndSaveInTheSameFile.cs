using System;
using System.IO;

class DeleteLinesAndSaveInTheSameFile
{
    static void Main()
    {
        string path = @"../../DeleteLines.txt";
        string pathWrite = @"../../copyFile.txt";
        StreamReader reader = new StreamReader(path);
        StreamWriter writer = new StreamWriter(pathWrite);

        using (reader)
        {
            using (writer)
            {
                string str = reader.ReadLine();
                int counter = 1;
                while (str != null)
                {
                    if (counter % 2 == 0)
                    {
                        writer.WriteLine(str);
                        counter++;
                    }
                    else
                    {
                        counter++;
                    }
                    str = reader.ReadLine(); 
                }
                writer.Flush();
            }
        }
        File.Delete(path);
        File.Move(pathWrite, path);
    }
}