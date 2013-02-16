using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceWholeWords
{
    class ReplaceWholeWords
    {
        static void Main()
        {
            string path = @"../../replaceWords.txt";
            string pathWrite = @"../../replaceWordsNewFile.txt";
            StreamReader reader = new StreamReader(path);
            StreamWriter writer = new StreamWriter(pathWrite);

            using (reader)
            {
                using (writer)
                {
                    string str = reader.ReadLine();
                    while (str != null)
                    {
                        string pattern = @"\bStart\b";
                        string replace = "Finish";
                        string result = Regex.Replace(str, pattern, replace);
                        writer.WriteLine(result);
                        str = reader.ReadLine();
                    }
                    writer.Flush();
                }
            }
        }
    }
}
