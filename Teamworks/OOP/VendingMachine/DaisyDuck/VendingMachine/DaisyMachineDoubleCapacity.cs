using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class DaisyMachineDoubleCapacity : Machine
    {
        //private readonly string model = "Daisy Coffe Machine version 1.0"

        private readonly int loadCoffee = 10000;
        private readonly int loadTea = 4000;
        private readonly int loadChocolate = 6000;
        private readonly int loadSugar = 8000;
        private readonly int loadMilk = 4000;
        private readonly int loadCups = 1000;
        private readonly int loadMixers = 1000;

        // constructor of Daisy Machine, where we load the machine
        public DaisyMachineDoubleCapacity(int machinePrice, string machineName)
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
    }
}
