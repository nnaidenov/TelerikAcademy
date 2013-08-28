using System;
using System.IO;

namespace ComparesTwoTextFiles
{
    class ComparesTwoTextFiles
    {
        static void Main()
        {
            string pathOne = @"../../firstFile.txt";
            string pathTwo = @"../../secondFile.txt";

            StreamReader firstReader = new StreamReader(pathOne);
            StreamReader secondReader = new StreamReader(pathTwo);

            using (firstReader)
            {
                using (secondReader)
                {
                    int line = 0;
                    string firstFileLine = firstReader.ReadLine();
                    string secondFileLine = secondReader.ReadLine();

                    while (firstFileLine != null)
                    {
                        line++;
                        if (firstFileLine == secondFileLine)
                        {
                            Console.WriteLine("Lines {0} are same!", line);
                        }
                        else
                        {
                            Console.WriteLine("Lines {0} are differnet!", line);
                        }

                        firstFileLine = firstReader.ReadLine();
                        secondFileLine = secondReader.ReadLine();
                    }
                }
            }
        }
    }
}
