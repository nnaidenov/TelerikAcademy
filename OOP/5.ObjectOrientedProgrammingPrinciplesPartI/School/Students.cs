using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Students : People
    {
        private byte number;

        public Students()
        {
        }

        public Students(string name, string comment, byte number)
        {
            this.Number = number;
            this.Name = name;
        }

        public byte Number
        {
            get { return this.number; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.number = value;
                }
            }
        }
    }
}
