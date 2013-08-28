using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.DifferentLetters
{
    class DifferentLetters
    {
        static void Main(string[] args)
        {
            string word = "DifferentLetters".ToLower();
            char[] symb = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] count = new int[symb.Length];

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < symb.Length; j++)
                {
                    if (word[i] == symb[j])
                    {
                        count[j]++;
                    }
                }
            }

            for (int i = 0; i < symb.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} - {1} times", symb[i], count[i]);
                }
            }
        }
    }
}