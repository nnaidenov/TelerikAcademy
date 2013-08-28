using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    public class Person
    {
        public string name { get; set; }
        public int? age { get; set; }

        //Override ToString()
        public override string ToString()
        {
            if (this.age == null)
            {
                return string.Format("Name: {0} \n\rAge is not specified!", name);
            }
            else
            {
                return string.Format("Name: {0} \n\rAge: {1}", name, age);
            }
           
        }
    }
}
