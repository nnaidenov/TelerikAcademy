using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTask
{
    public class Student : Human
    {
        //Fields
        private byte grade;
        //END Fields

        //Constructors
        public Student(byte grade, string firstName, string lastName)
            : base(firstName, lastName) //From Parent Class
        {
            this.Grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        //END Constructors

        //Properties
        public byte Grade
        {
            get { return this.grade; }
            set 
            {
                if (value > 0)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        //END Properties

        //Override ToString()
        public override string ToString()
        {
            return string.Format("{0} {1}, Grade - {2}", this.FirstName, this.LastName, this.grade);
        }
        //END Override ToString()
    }
}
