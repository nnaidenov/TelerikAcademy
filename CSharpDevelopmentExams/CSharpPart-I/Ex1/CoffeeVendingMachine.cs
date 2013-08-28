using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class CoffeeVendingMachine
    {
        static void Main(string[] args)
        {
            decimal totalCoinsInMachine = 0;
            decimal fiveCoins = Convert.ToDecimal(Console.ReadLine());
            decimal tenCoins = Convert.ToDecimal(Console.ReadLine());
            decimal twentyCoins = Convert.ToDecimal(Console.ReadLine());
            decimal fiftyCoins = Convert.ToDecimal(Console.ReadLine());
            decimal oneCoins = Convert.ToDecimal(Console.ReadLine());

            totalCoinsInMachine += (fiveCoins * 0.05m);
            totalCoinsInMachine += (tenCoins * 0.1m);
            totalCoinsInMachine += (twentyCoins * 0.2m);
            totalCoinsInMachine += (fiftyCoins * 0.5m);
            totalCoinsInMachine += (oneCoins);

            decimal insertCoins = Convert.ToDecimal(Console.ReadLine());
            decimal price = Convert.ToDecimal(Console.ReadLine());

            if (insertCoins < price)
            {
                Console.WriteLine("More {0}", price - insertCoins);
            }

            if (insertCoins >= price)
            {
                decimal diff = insertCoins - price;

                if (diff <= totalCoinsInMachine)
                {
                    Console.WriteLine("Yes {0}", totalCoinsInMachine - diff);
                }

                if (diff > totalCoinsInMachine)
                {
                    Console.WriteLine("No {0}", diff - totalCoinsInMachine);
                }
            }
            //
        }
    }
}
