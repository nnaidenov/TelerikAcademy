using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTask
{
    public abstract class Human
    {
        //Fields
        private string firstName;
        private string lastName;
        //END Fields

        //Constructors
        public Human()
        {
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        //END Constructors

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }
        //END Properties
    }
}
