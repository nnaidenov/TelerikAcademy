using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    class Dog : Animal, ISoundable
    {
        public Dog(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override void produceSound()
        {
            Console.WriteLine("I am Dog!");
        }
    }
}
