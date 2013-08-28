using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Menu
    {
        public string[,] menuItems { get; set; }

        //Make menu
        public Menu()
        {
            int count = Enum.GetValues(typeof(DrinksEnum)).Length;
            menuItems = new string[count, 3];
        }

        //Fill menu
        public void AddItemsToMenu()
        {
            //DrinkCode
            menuItems[0, 0] = "(1)";
            menuItems[1, 0] = "(2)";
            menuItems[2, 0] = "(3)";
            menuItems[3, 0] = "(4)";

            //DrinkPrice
            menuItems[0, 1] = Convert.ToString(DrinksPrices.coffeePrice);
            menuItems[1, 1] = Convert.ToString(DrinksPrices.teaPrice);
            menuItems[2, 1] = Convert.ToString(DrinksPrices.chocolatePrice);
            menuItems[3, 1] = Convert.ToString(DrinksPrices.cappuccinoPrice);

            //DrinkName
            int count = 0;
            foreach (var value in Enum.GetValues(typeof(DrinksEnum)))
            {
                menuItems[count, 2] = Convert.ToString((DrinksEnum)value);
                count++;
            }
        }
    }
}
