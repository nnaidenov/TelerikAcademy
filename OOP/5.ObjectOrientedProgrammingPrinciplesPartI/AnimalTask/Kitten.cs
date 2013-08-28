using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    class Kitten : Cat, ISoundable
    {
        public Kitten(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = Sex.female;
        }

        public override void produceSound()
        {
            Console.WriteLine("I am Kitten!"); 
        }
    }
}
