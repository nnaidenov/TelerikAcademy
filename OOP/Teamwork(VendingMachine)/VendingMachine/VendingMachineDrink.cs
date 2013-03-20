using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachineDrink : Drink
    {
        public string NameDrink { get; private set; }

        public VendingMachineDrink(int countCoffee, int countTea, int countChocolate, int countMilk, int countSugar, int countCup, int countMixer, string nameDrink)
            : base(countCoffee, countTea, countChocolate, countMilk, countSugar, countCup, countMixer)
        {
            this.NameDrink = nameDrink;
        }
    }
}