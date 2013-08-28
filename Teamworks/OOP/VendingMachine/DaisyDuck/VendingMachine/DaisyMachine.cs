using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class DaisyMachine : Machine
    {
        //private readonly string model = "Daisy Coffe Machine version 1.1";

        private readonly int loadCoffee = 500;
        private readonly int loadTea = 500;
        private readonly int loadChocolate = 500;
        private readonly int loadSugar = 500;
        private readonly int loadMilk = 500;
        private readonly int loadCups = 500;
        private readonly int loadMixers = 500;

        // constructor of Daisy Machine, where we load the machine
        public DaisyMachine(int machinePrice, string machineName)
            : base(machinePrice, machineName)
        {
            Ingredients loadIngredients = new Ingredients();

            loadIngredients.Coffee = this.loadCoffee;
            loadIngredients.Tea = this.loadTea;
            loadIngredients.Chocolate = this.loadChocolate;
            loadIngredients.Sugar = this.loadSugar;
            loadIngredients.Milk = this.loadMilk;
            loadIngredients.Cups = this.loadCups;
            loadIngredients.Mixers = this.loadMixers;
            this.TheIngredients = loadIngredients;
        }

        public void DisplayQ()
        {
            Console.Write("Coffee amount: ");
            Console.WriteLine(TheIngredients.Coffee);
        }
    }
}
