using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodesAndDecodes
{
    class EncodesAndDecodes
    {
        static void Main()
        {
            string str = "Some text for crypting and decrypting!";
            string key = "The key";

            char[] strArr = str.ToCharArray();
            char[] keyArr = key.ToCharArray();
            StringBuilder encode = new StringBuilder();
            StringBuilder decode = new StringBuilder();

            for (int i = 0, k = 0; i < strArr.Length; i++, k++)
            {
                if (keyArr.Length == k)
                {
                    k = 0;
                }
                encode.Append((char)(strArr[i] ^ keyArr[k]));
            }

            Console.WriteLine(encode);

            for (int i = 0, k = 0; i < encode.Length; i++, k++)
            {
                if (keyArr.Length == k)
                {
                    k = 0;
                }
                decode.Append((char)(encode[i] ^ keyArr[k]));
            }
            Console.WriteLine(decode);
        }
    }
}
