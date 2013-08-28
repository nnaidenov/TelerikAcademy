using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ChangeSweetness
    {
        public static void ChangeSweet(List<string> sweet)
        {
            Program.Product = new Sugar();
            Program.Product.PropertyChange += new Sugar.PropertyChangeHandler(Sugar.PropertyHasChanged);
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.OemPlus || input.Key == ConsoleKey.Add)
                {
                    Program.Product.Sweetness++;
                    Sugar.AddSweet(Program.Product.Sweetness, sweet);
                }
                else if (input.Key == ConsoleKey.OemMinus || input.Key == ConsoleKey.Subtract)
                {
                    Program.Product.Sweetness--;
                    Sugar.DellSweet(Program.Product.Sweetness, sweet);
                }
                if (input.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
