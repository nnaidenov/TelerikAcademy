using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExtenMethodSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Testing text.");
            Console.WriteLine(str.Substring(0, 7).ToString());
        }
    }
}
