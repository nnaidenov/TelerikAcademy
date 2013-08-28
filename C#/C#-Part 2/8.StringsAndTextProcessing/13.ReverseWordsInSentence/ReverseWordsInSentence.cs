using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            int length = sentence.Length;
                         //   "Delphi not and PHP, not C++ not is C#!"
            string[] words = sentence.Split(new char[] {' ', ',', '!', '.'}, length, StringSplitOptions.RemoveEmptyEntries);
            string[] symbols = sentence.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, length, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder newSentence = new StringBuilder(sentence.Length);

            for (int word = words.Length-1, symbol = 0; word >= 0 ; word--, symbol++)
            {
                newSentence.AppendFormat(words[word]);
                newSentence.AppendFormat(symbols[symbol]);
            }
            Console.WriteLine(sentence);
            Console.WriteLine(newSentence);
        }
    }
}