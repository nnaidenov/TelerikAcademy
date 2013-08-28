using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountSubstringContainedInText
{
    class CountSubstringContainedInText
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToUpper();
            string template = "in".ToUpper();

            int count = Regex.Matches(text, template).Count;
            Console.WriteLine(count);
        }
    }
}