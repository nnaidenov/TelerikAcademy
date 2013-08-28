using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.DelegatesTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.ExecuteMethod(1000);
        }
    }
}
