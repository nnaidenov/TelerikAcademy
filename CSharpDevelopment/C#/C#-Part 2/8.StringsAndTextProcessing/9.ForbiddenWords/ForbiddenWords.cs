using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] words = { "Microsoft", "PHP", "CLR" };
            string print = "";
            for (int i = 0; i < words.Length; i++)
            {
                string replace = new string('*', words[i].Length);
                print = text.Replace(words[i], replace);
                text = print;
            }

            Console.WriteLine(print);
        }
    }
}