using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindroms
{
    class Palindroms
    {
        static void Main(string[] args)
        {
            string str = "Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria. I don`t know what is lamal, maybe I will find some day. mouseesuom";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };

            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                bool isPal = false;
                for (int j = 0; j < word.Length/2; j++)
                {
                    if (word[j] == word[word.Length-1-j])
                    {
                        isPal = true;
                    }
                    else
                    {
                        isPal = false;
                    }
                }
                if (isPal)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
