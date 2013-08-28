using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.DeleteSameSymbols
{
    class DeleteSameSymbols
    {
        static void Main(string[] args)
        {
            string str = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder newStr = new StringBuilder();

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    newStr.Append(str[i]);
                }
            }

            newStr.Append(str[str.Length - 1]);

            Console.WriteLine(newStr);
        }
    }
}