using System;
using System.IO;
using System.Text.RegularExpressions;

class ReadCountAndWrite
{
    static void Main()
    {
        try
        {
            StreamReader wordsPath = new StreamReader("../../words.txt");
            StreamReader testPath = new StreamReader("../../test.txt");
            StreamWriter writer = new StreamWriter("../../result.txt");

            using (wordsPath)
            {
                using (testPath)
                {
                    using (writer)
                    {
                        string textLine = testPath.ReadToEnd();
                        string wordsLine = wordsPath.ReadLine();

                        while (wordsLine != null)
                        {
                            string template = wordsLine;
                            Console.WriteLine(template);
                            writer.Write(template + ": ");
                            writer.WriteLine(Regex.Matches(textLine, template).Count);
                            wordsLine = wordsPath.ReadLine();
                        }
                        writer.Flush();
                    }
                }
            }
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}