using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            double numberOfTours = double.Parse(Console.ReadLine());
            long mitkoBeers = 0;
            long vladoBeers = 0;

            for (int i = 0; i < numberOfTours; i++)
            {
                List<int> beersInTour = new List<int>();
                long currTourr = long.Parse(Console.ReadLine());
                long currTour = Math.Abs(currTourr);
                string beers = currTour + "";
                if (beers.Length % 2 == 0)
                {
                    for (int j = 0; j < beers.Length / 2; j++)
                    {
                        if (beers[j] != '-')
                        {
                            beersInTour.Add(Convert.ToInt32(beers[j] + " "));
                        }
                       
                    }
                    foreach (var beer in beersInTour)
                    {
                        mitkoBeers += beer;
                    }
                    beersInTour.Clear();

                    for (int j = beers.Length - 1; j >= beers.Length / 2; j--)
                    {
                        if (beers[j] != '-')
                        {
                            beersInTour.Add(Convert.ToInt32(beers[j] + " "));
                        }
                    }
                    foreach (var beer in beersInTour)
                    {
                        vladoBeers += beer;
                    }
                    beersInTour.Clear();
                }

                if (beers.Length % 2 == 1)
                {
                    for (int j = 0; j < (beers.Length / 2) + 1; j++)
                    {
                        if (beers[j] != '-')
                        {
                            beersInTour.Add(Convert.ToInt32(beers[j] + ""));
                        }
                    }
                    foreach (var beer in beersInTour)
                    {
                        mitkoBeers += beer;
                    }
                    beersInTour.Clear();

                    for (int j = beers.Length - 1; j >= (beers.Length / 2); j--)
                    {
                        if (beers[j] != '-')
                        {
                            beersInTour.Add(Convert.ToInt32(beers[j] + ""));
                        }
                    }
                    foreach (var beer in beersInTour)
                    {
                        vladoBeers += beer;
                    }
                    beersInTour.Clear();
                }
            }

            if ((mitkoBeers - vladoBeers) > 0)
            {
                Console.WriteLine("M {0}", mitkoBeers - vladoBeers);
            }

            if ((mitkoBeers - vladoBeers) < 0)
            {
                Console.WriteLine("V {0}", vladoBeers - mitkoBeers);
            }

            if ((mitkoBeers - vladoBeers) == 0)
            {
                Console.WriteLine("No {0}", vladoBeers + mitkoBeers);
            }
        }
    }
}
