using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextWithoutTags
{
    static void Main()
    {
        string path = @"../../xml.txt";

        StreamReader reader = new StreamReader(path);

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string pattern = ">[^<]*<";
                string edited;
                foreach (Match match in Regex.Matches(line, pattern))
                {
                    edited = match.Value.ToString();

                    if (edited != null)
                    {
                        Console.WriteLine(edited);
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}