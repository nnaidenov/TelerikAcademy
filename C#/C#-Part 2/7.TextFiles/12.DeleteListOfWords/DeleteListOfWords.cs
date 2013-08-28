using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteListOfWords
{
    static void Main()
    {
        try
        {
            StreamReader listPath = new StreamReader("../../lisst.txt");
            StreamReader textPath = new StreamReader("../../text.txt");
            StreamWriter writer = new StreamWriter("../../output.txt");

            using (listPath)
            {
                using (textPath)
                {
                    using (writer)
                    {
                        string listLine = listPath.ReadLine();
                        string textLine = textPath.ReadToEnd();
                        while (listLine != null)
                        {
                            string template = listLine;
                            string replace = "";
                            textLine = Regex.Replace(textLine, template, replace);

                            listLine = listPath.ReadLine();
                        }
                        writer.WriteLine(textLine);
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