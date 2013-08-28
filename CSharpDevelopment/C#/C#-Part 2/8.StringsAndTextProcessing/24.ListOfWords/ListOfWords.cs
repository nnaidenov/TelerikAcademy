using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.ListOfWords
{
    class ListOfWords
    {
        static void Main(string[] args)
        {
            string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };

            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
