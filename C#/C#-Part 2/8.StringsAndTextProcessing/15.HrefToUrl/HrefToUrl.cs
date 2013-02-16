using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.HrefToUrl
{
    class HrefToUrl
    {
        static void Main(string[] args)
        {
            string str = @"<p>Please visit <a href=""http://academy.telerik.com""> our site</a> to choose a training course. Also visit <a href=""www.devbg.org""> our forum</a> to discuss the courses.</p>";
            string patternOne = @"<a href=""";
            string patternTwo = @""">";
            string patternThree = @"</a>";

            string replOne = Regex.Replace(str, patternOne, "[URL=");
            string replTwo = Regex.Replace(replOne, patternTwo, "]");
            string final = Regex.Replace(replTwo, patternThree, "[/URL]");

            Console.WriteLine(final);
        }
    }
}
