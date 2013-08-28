using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversString
{
    class ReversString
    {
        static void Main()
        {
            string word = "sample";
            char[] revers = new char[word.Length];

            for (int pos = 0, sym = word.Length-1; pos < revers.Length; pos++, sym--)
            {
                revers[pos] = word[sym];
            }

            Console.WriteLine(word);
            foreach (var a in revers)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}
