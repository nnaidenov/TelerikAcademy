using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    class Tomcat : Cat, ISoundable
    {
        public Tomcat(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = Sex.male;
        }

        public override void produceSound()
        {
            Console.WriteLine("I am Tomcat!");
        }
    }
}
