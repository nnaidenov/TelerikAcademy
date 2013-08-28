using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.HtmlReadAndExtract
{
    class HtmlReadAndExtract
    {
        static void Main(string[] args)
        {
            string str = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>";

            string pattern = @"(?<=^|>)[^><]+?(?=<|$)";

            Match text = Regex.Match(str, pattern);

            while (text.Success)
            {
                Console.WriteLine(text);
                text = text.NextMatch();
            }     
        }
    }
}
