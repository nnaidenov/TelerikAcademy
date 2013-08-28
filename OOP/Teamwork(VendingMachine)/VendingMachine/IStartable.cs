using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IStartable
    {
        void MachineTurnOn(int sug);
        void MachineTurnOn();
    }
}
