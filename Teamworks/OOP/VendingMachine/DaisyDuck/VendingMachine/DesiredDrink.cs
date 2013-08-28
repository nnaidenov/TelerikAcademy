using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class DesiredDrink
    {
        public static int CheckDrink(decimal total, ConsoleKeyInfo inputCode, DaisyMachine newDaisyMachine, int sug)
        {
                if (inputCode.Key == ConsoleKey.NumPad1 || inputCode.Key == ConsoleKey.D1) // Coffee
                {
                    Console.WriteLine();
                    VendingMachineDrink newCoffee = new VendingMachineDrink(390, 0, 0, 20, sug, 1, 1, "Coffee");
                    decimal price = DrinksPrices.coffeePrice;
                    return CollectMoney(price, total, newDaisyMachine, newCoffee);
                }
                else if (inputCode.Key == ConsoleKey.NumPad2 || inputCode.Key == ConsoleKey.D2) // Tea
                {
                    Console.WriteLine();
                    VendingMachineDrink newTea = new VendingMachineDrink(0, 50, 0, 0, sug, 1, 1, "Tea");
                    decimal price = DrinksPrices.teaPrice;
                    return CollectMoney(price, total, newDaisyMachine, newTea);
                }
                else if (inputCode.Key == ConsoleKey.NumPad3 || inputCode.Key == ConsoleKey.D3) // Chocolate
                {
                    Console.WriteLine();
                    VendingMachineDrink newChocolate = new VendingMachineDrink(0, 0, 100, 20, sug, 1, 1, "Chocolate");
                    decimal price = DrinksPrices.chocolatePrice;
                    return CollectMoney(price, total, newDaisyMachine, newChocolate);
                }
                else if (inputCode.Key == ConsoleKey.NumPad4 || inputCode.Key == ConsoleKey.D4) // Cappuccino
                {
                    Console.WriteLine();
                    VendingMachineDrink newCappuccino = new VendingMachineDrink(10, 0, 20, 50, sug, 1, 1, "Cappuccino");
                    decimal price = DrinksPrices.cappuccinoPrice;
                    return CollectMoney(price, total, newDaisyMachine, newCappuccino);
                }
                else
                {
                    Console.WriteLine("Please insert valide DrinkCode.");
                    Console.WriteLine();
                    return 3;
                }
        }

        //Check input Coins and DrinkPrice
        public static int CollectMoney(decimal price, decimal total, DaisyMachine newDaisyMachine, VendingMachineDrink newDrink)
        {
            decimal change = total - price;
            if (total == price)
            { 
                Console.Clear();
                newDaisyMachine.PrepareDrink(newDrink);
                GiveChange.PayChangeBack(change);
                FinalPicture.displayPicture();
                Console.Beep(700, 1000);
                return 1;
            }
            else if (total > price)
            {
                Console.Clear();
                newDaisyMachine.PrepareDrink(newDrink);
                GiveChange.PayChangeBack(change);
                FinalPicture.displayPicture();
                Console.Beep(700, 5000);
                return 1;
            }
            else
            {
                decimal more = price - total;
                Console.WriteLine("Please insert: {0}лв.", more);
                return 2;
            }
        }
    }
}
