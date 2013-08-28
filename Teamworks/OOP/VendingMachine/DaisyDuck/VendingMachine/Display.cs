using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Display
    {
        //Display Menu
        public static void DisplayMenu(Menu menu)
        {
            Console.WriteLine("{0, 15}", "Menu");
            Console.WriteLine();
            for (int row = 0; row < menu.menuItems.GetLength(0); row++)
            {
                for (int col = 0; col < menu.menuItems.GetLength(1); col++)
                {
                    if (col == 1)
                    {
                        Console.Write((menu.menuItems[row, col] + "лв").PadRight(7));
                    }
                    else
                    {
                        Console.Write(menu.menuItems[row, col].PadRight(5));
                    }
                }
                Console.WriteLine();
            }
        }

        //Make and Display Steps
        public static void DisplaySteps()
        {
            StringBuilder steps = new StringBuilder();
            steps.AppendLine("Wellcome to Daisy Duck Machine!");
            steps.AppendLine("-------------------------------");
            steps.AppendLine("Please read and follow steps!");
            steps.AppendLine();
            steps.AppendLine("1.Check the price of the desired drink.");
            steps.AppendLine("2.Insert coins.(1,00  0,50  0,20  0,10)");
            steps.AppendLine("3.Choose the degree of sweetness.(+ -)");
            steps.AppendLine("4.Press the corresponding number.");
            steps.AppendLine("5.Wait for the beep.");
            steps.AppendLine("6.Get your drink.");
            steps.AppendLine("-------------------------------"); 
            //Console.WriteLine();
            Console.SetWindowSize(85, 35);
            Console.WriteLine(steps.ToString());

        }
    }
}
