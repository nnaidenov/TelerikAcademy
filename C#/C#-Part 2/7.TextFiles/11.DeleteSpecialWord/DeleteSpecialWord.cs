using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteSpecialWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../start.txt");
        StreamWriter writer = new StreamWriter("../../output.txt");
        string line; 
        using (reader)
        {
            using (writer)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"(\b)start((\w)*)(\b)", String.Empty));
                }
            }
        }
    }
}