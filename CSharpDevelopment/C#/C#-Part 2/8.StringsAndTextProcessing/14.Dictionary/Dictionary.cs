using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
            };

            StringBuilder means = new StringBuilder();
            string word = "CLR";
            
            for (int i = 0; i < dictionary.Length; i++)
            {
                string[] split = Regex.Split(dictionary[i], "(.*?) - (.*)");
                for (int j = 1; j <= 2; j++)
                {
                    if (split[j] == word)
                    {
                        means.AppendFormat("{0} - {1}.", word, split[j + 1]);
                    }
                }
                
            }

            Console.WriteLine(means);
        }
    }
}
