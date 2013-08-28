using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.RecognizedMails
{
    class RecognizedMails
    {
        static void Main(string[] args)
        {
            string str = @"A @telerik.com. This baj.i_van@yahoo.co.uk. This is   also: ISTRUEexa_mple@abv.bg";

            string pattern = @"\b[a-z0-9\._]+@\b[a-z0-9]+\.[a-z]+";

            Match mail = Regex.Match(str, pattern);

            while (mail.Success)
            {
                Console.WriteLine(mail);
                mail = mail.NextMatch();
            }
        }
    }
}
