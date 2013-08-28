using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public delegate void DelegateStartWork();

    class StartMachine : IStartable
    {
        public int shugarQ { get; set; }
        private void TurnOnDisplay()
        {
            Menu myMenu = new Menu();
            Display.DisplaySteps();
            myMenu.AddItemsToMenu();
            Display.DisplayMenu(myMenu);
        }

        public void MachineTurnOn()
        {
            DelegateStartWork delegateTimer = this.TurnOnDisplay;
            delegateTimer();
        }

        public void MachineTurnOn(int sug)
        {
            DelegateStartWork delegateTimer = this.TurnOnDisplay;
            this.shugarQ = sug;
            delegateTimer();
        }
    }
}
