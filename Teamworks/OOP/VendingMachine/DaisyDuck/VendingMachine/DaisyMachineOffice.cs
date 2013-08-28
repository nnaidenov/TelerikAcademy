using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class DaisyMachineOffice : Machine
    {
        //private readonly string model = "Daisy Coffe Machine version 1.2"

        private readonly int loadCoffee = 2500;
        private readonly int loadTea = 1000;
        private readonly int loadChocolate = 1500;
        private readonly int loadSugar = 2000;
        private readonly int loadMilk = 1000;
        private readonly int loadCups = 200;
        private readonly int loadMixers = 200;

        // constructor of Daisy Machine, where we load the machine
        public DaisyMachineOffice(int machinePrice, string machineName)
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
