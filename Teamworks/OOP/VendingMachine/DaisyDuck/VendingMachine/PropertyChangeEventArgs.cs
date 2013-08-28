using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class PropertyChangeEventArgs : EventArgs
    {
        public int NewValue { get; internal set; }

        public PropertyChangeEventArgs(int newValue)
        {
            this.NewValue = newValue;
        }
    }
}
