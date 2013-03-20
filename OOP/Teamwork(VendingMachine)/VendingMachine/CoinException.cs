using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class CoinException : ApplicationException
    {
        public CoinException(string message) :
            base(message)
        {

        }
    }
}
