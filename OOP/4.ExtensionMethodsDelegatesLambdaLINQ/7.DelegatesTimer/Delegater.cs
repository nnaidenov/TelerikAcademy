using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.DelegatesTimer
{
    public delegate void DelegateTimer();

    public class Timer
    {
        private void SayTelerik()
        {
            Console.WriteLine("Telerik.");
        }

        public void Sleep(int timeInterval)
        {
            Thread.Sleep(timeInterval);
        }

        public void ExecuteMethod(int timeInterval)
        {
            DelegateTimer delegateTimer = this.SayTelerik;
            int stopper = 0;

            while (stopper < 10)
            {
                delegateTimer();
                Thread.Sleep(timeInterval);
                stopper++;
            }
        }
    }
}