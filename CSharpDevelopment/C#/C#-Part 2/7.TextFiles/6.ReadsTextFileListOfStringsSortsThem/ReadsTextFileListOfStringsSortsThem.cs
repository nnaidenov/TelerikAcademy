using System;
using System.IO;

namespace ReadsTextFileListOfStringsSortsThem
{
    class ReadsTextFileListOfStringsSortsThem
    {
        static void Main()
        {
            string path = @"../../names.txt";
            int lineNumber = File.ReadAllLines(path).Length;
            StreamReader readNames = new StreamReader(path);

            ReadFile(readNames, lineNumber);
        }

        private static void ReadFile(StreamReader readNames, int lineNumber)
        {
            string[] namesArray = new string[lineNumber];
            string line = readNames.ReadLine();
            int cell = 0;
            while (line != null)
            {
                namesArray[cell] = line;
                line = readNames.ReadLine();
                cell++;
            }

            SortArray(namesArray);
        }

        private static void SortArray(string[] namesArray)
        {
            Array.Sort(namesArray);

            PrintArray(namesArray);
        }

        private static void PrintArray(string[] namesArray)
        {
            for (int cell = 0; cell < namesArray.Length; cell++)
            {
                Console.WriteLine(namesArray[cell]);
            }
        }
    }
}
