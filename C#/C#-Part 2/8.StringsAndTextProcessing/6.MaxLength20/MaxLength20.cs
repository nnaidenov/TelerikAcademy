using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLength20
{
    class MaxLength20
    {
        static void Main(string[] args)
        {
            string str = "Blablala";

            StringBuilder builder = new StringBuilder(20);
            builder.Append(str);
            if (str.Length < 20)
            {
                builder.Append('*', 20 - str.Length);
            }
            Console.WriteLine(builder);
        }
    }
}