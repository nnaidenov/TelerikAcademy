using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class StringsandTextProcessing
    {
        static void Main()
        {
            string normal = "sample";
            Console.WriteLine(normal);

            char[] array = new char[normal.Length];

            for (int pos = 0, charpos = normal.Length-1; pos < array.Length; pos++, charpos--)
            {
                array[pos] = normal[charpos];
            }

            foreach (var a in array)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }