using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacterLiterals
{
    class UnicodeCharacterLiterals
    {
        static void Main(string[] args)
        {
            string str = "Hi!";

            for (int i = 0; i < str.Length; i++)
            {
                int symb = (char)str[i];
                string format = String.Format("\\u{0:X4}", symb);
                Console.Write(format);
            }
            Console.WriteLine();
        }
    }
}
