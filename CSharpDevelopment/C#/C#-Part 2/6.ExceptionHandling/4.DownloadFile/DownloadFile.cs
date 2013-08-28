using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            using (WebClient Client = new WebClient())
            {
                try
                {
                    Client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "Logo-BASD.jpg");
                    Console.WriteLine("Done!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address parameter is null.");
                }
                catch (WebException)
                {
                    Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.-or-filename is null or Empty.-or-The file does not exist.-or- An error occurred while downloading data.");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
