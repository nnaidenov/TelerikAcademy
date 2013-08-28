using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExtenMethodSubstring
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder returnValue = new StringBuilder();

            if (length >= str.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }
            else if (length <=0)
            {
                throw new ArgumentException("Argument exeption");
            }
            else if (index + length >= str.Length - 1)
            {
                throw new ArgumentException("Argument exeption");
            }

            for (int i = index; i < index+length; i++)
            {
                returnValue.Append(str[i]);
            }
            return returnValue;
        }
    }
}
