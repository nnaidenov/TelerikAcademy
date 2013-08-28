using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    public abstract class Animal : ISoundable
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal()
        { }

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Sex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public abstract void produceSound();

        public override string ToString()
        {
            return string.Format("My name is {0}. I'm {1} years old. I'm a {2}.", this.Name, this.Age, this.Sex);
        }

        public static double AverageAge(Animal[] animals)
        {
            int animalsAge = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                var animal = animals[i];
                animalsAge += animal.Age;
            }
            return (double)animalsAge / animals.Length;
        }
    }
}
