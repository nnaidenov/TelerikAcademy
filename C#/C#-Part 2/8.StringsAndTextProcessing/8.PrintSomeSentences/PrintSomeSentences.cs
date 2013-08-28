using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.PrintSomeSentences
{
    class PrintSomeSentences
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] sentence = text.Split('.');

            for (int row = 0; row < sentence.Length; row++)
            {
                if (Regex.Matches(sentence[row], @"\bin\b").Count > 0)
                {
                    Console.WriteLine((sentence[row] + ".").Trim());
                }
            }
        }
    }
}