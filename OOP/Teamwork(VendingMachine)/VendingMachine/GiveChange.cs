using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class GiveChange
    {
        private decimal change;

        public decimal Change
        {
            set { this.change = value; }
        }

        public static void PayChangeBack(decimal change)
        {
            if (change > 0)
            {
                Console.WriteLine("Take your change:");
            }
            // as maximal amount cannot be ovev 1.50, the cheepest drink is tea 0.50, so maximal change is 1.00
            string changeToString = change.ToString();
            switch (changeToString)
            {
                case "1.90": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.20"); break;
                case "1.80": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.10"); break;
                case "1.70": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.20"); break;
                case "1.60": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.10"); break;
                case "1.50": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.50"); break;
                case "1.40": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.20"); break;
                case "1.30": Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.20"); Console.WriteLine("0.10"); break;
                case "1.20": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.20"); break;
                case "1.10": Console.WriteLine("0.50"); Console.WriteLine("0.50"); Console.WriteLine("0.10"); break;
                case "1.00": Console.WriteLine("0.50"); Console.WriteLine("0.50"); break;
                case "0.90": Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.20"); break;
                case "0.80": Console.WriteLine("0.50"); Console.WriteLine("0.20"); Console.WriteLine("0.10"); break;
                case "0.70": Console.WriteLine("0.50"); Console.WriteLine("0.20"); break;
                case "0.60": Console.WriteLine("0.50"); Console.WriteLine("0.10"); break;
                case "0.50": Console.WriteLine("0.50"); break;
                case "0.40": Console.WriteLine("0.20"); Console.WriteLine("0.20"); break;
                case "0.30": Console.WriteLine("0.20"); Console.WriteLine("0.10"); break;
                case "0.20": Console.WriteLine("0.20"); break;
                case "0.10": Console.WriteLine("0.10"); break;
                default: Console.WriteLine("There is no change");
                    break;
            }
        }
    }
}
