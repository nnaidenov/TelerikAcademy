using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.URLadress
{
    class URLadress
    {
        static void Main(string[] args)
        {
            string url = @"http://www.devbg.org/forum/dss/index.com";
            string protocol = "http";
            string server = "www.devbg.org";
            string resource = "/forum/index.php";

            string patternProtocol = @"\w+:";
            string patternServer = @"[w]{3}\.\w+\.\w+";
            string patternResource = @"\b/[^/][\w]*.+";

            Match matchProtocol = Regex.Match(url, patternProtocol);
            Match matchServer = Regex.Match(url, patternServer);
            Match matchResource = Regex.Match(url, patternResource);

            while (matchProtocol.Success)
            {
                Console.WriteLine(matchProtocol);
                matchProtocol = matchProtocol.NextMatch();
            }
            while (matchServer.Success)
            {
                Console.WriteLine(matchServer);
                matchServer = matchServer.NextMatch();
            }
            while (matchResource.Success)
            {
                Console.WriteLine(matchResource);
                matchResource = matchResource.NextMatch();
            }
        }
    }
}
