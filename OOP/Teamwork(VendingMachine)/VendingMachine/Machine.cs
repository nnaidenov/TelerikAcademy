using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Machine : IDrinkable
    {
        protected int Price { get; private set; }

        protected string Name { get; private set; }

        protected Ingredients TheIngredients { get; set; }

        public Machine(int price, string name)
        {
            this.Price = price;
            this.Name = name;
        }

        // implement abstract method PrepareDrink from IDrinkable
        public void PrepareDrink(Drink drink)
        {
            bool isEmptyMachine = (this.TheIngredients.Coffee - drink.CountCoffee >= 0) &&
                (this.TheIngredients.Tea - drink.CountTea >= 0) &&
                (this.TheIngredients.Chocolate - drink.CountChocolate >= 0  ) &&
                (this.TheIngredients.Milk - drink.CountMilk >= 0) &&
                (this.TheIngredients.Sugar - drink.CountSugar >= 0) &&
                (this.TheIngredients.Cups - drink.CountCups >= 0) &&
                (this.TheIngredients.Mixers - drink.CountMixers >= 0);

            if (isEmptyMachine == false)
            {
                
                Console.WriteLine("Low products level");
                Console.WriteLine("Take your money back.");
                Environment.Exit(0);
            }
            else
            {
                Ingredients tempIngredients = new Ingredients();
                tempIngredients = this.TheIngredients;

                tempIngredients.Coffee -= drink.CountCoffee;
                tempIngredients.Tea -= drink.CountTea;
                tempIngredients.Chocolate -= drink.CountChocolate;
                tempIngredients.Milk -= drink.CountMilk;
                tempIngredients.Sugar -= drink.CountSugar;
                tempIngredients.Cups -= drink.CountCups;
                tempIngredients.Mixers -= drink.CountMixers;

                this.TheIngredients = tempIngredients;
            }
        }
    }
}