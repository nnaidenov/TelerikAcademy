using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink: IHottable
    {
        public int CountCoffee { get; set; }
        public int CountTea { get; set; }
        public int CountChocolate { get; set; }
        public int CountMilk { get; set; }
        public int CountSugar { get; set; }
        public int CountCups { get; set; }
        public int CountMixers { get; set; }
        public int Temperature { get; set; }

        // трябва да се добавят конструктури в зависимост от напитката
        public Drink(int countCoffee, int countTea, int countChocolate, int countMilk, int countSugar, int countCup, int countMixer)
        {
            this.CountCoffee = countCoffee;
            this.CountTea = countTea;
            this.CountChocolate =countChocolate;
            this.CountMilk = countMilk;
            this.CountSugar = countSugar;
            this.CountCups = countCup;
            this.CountMixers = countMixer;
            this.Temperature = 20;
        }

        public void ControlTemperature(int temperature)
        {
            this.Temperature = temperature;
        }
    }
}
