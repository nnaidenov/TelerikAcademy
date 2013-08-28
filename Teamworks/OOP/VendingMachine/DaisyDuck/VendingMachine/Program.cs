using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        
        public static Sugar Product { get; set; }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                CultureInfo.InvariantCulture;

            DaisyMachine newDaisyMachine = new DaisyMachine(1500, "Daisy Machine");
            while (true)
            {
                Console.Clear();
                StartMachine turnOnMachine = new StartMachine();
                turnOnMachine.MachineTurnOn();

                List<string> sweet = new List<string>();
                Console.WriteLine();
                Console.WriteLine("Sugar + - and press n");
                ChangeSweetness.ChangeSweet(sweet);

                int sug = sweet.Count;
                turnOnMachine.MachineTurnOn(sug);

                newDaisyMachine.DisplayQ();

                Console.WriteLine();
                Console.WriteLine("Insert Coins And press 'n' to nextStep");
                decimal total = 0.0m;
                bool done = false;
                int doneChoise = 3;
                string input = "";
                while (done == false)
                {
                    if ((total < 1.00m))
                    {
                        input = Console.ReadLine();
                        if (input != "n")
                        {
                            total = CheckMoney.CheckCoin(input, total);
                            Console.WriteLine("Total coins: {0}", total);
                        }
                        else
                        {
                            doneChoise = 3;
                            while (doneChoise == 3)
                            {
                                ConsoleKeyInfo drinkCode;
                                Console.WriteLine("Pleace select Drink Code.");
                                drinkCode = Console.ReadKey();
                                doneChoise = DesiredDrink.CheckDrink(total, drinkCode, newDaisyMachine, sug);
                                if (doneChoise == 1)
                                {
                                    done = true;
                                }
                                else if (doneChoise == 2)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        doneChoise = 3;
                        while (doneChoise == 3)
                        {
                            ConsoleKeyInfo drinkCode;
                            Console.WriteLine("Pleace select Drink Code.");
                            drinkCode = Console.ReadKey();
                            doneChoise = DesiredDrink.CheckDrink(total, drinkCode, newDaisyMachine, sug);
                            if (doneChoise == 1)
                            {
                                done = true;
                            }
                        }
                    }
                }
                newDaisyMachine.DisplayQ();
            }
        }
    }
}