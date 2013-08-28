using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    abstract class People
    {
        private string name;
        private Comments comment;

        public People()
        {
        }

        public People(string name, Comments comment)
        {
            this.Name = name;
            this.comment = comment;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
