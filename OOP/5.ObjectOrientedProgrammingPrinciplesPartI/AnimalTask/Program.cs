using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog(7, "Balkan", Sex.male);
            Frog myFrog = new Frog(1, "Kermit", Sex.male);
            Tomcat myTomcat = new Tomcat(3, "Tom");
            Kitten myKitten = new Kitten(2, "Sisi");

            Animal[] animals = new Animal[4];

            animals[0] = myDog;
            animals[1] = myFrog;
            animals[2] = myTomcat;
            animals[3] = myKitten;

            Console.WriteLine(myFrog);
            myFrog.produceSound();

            double avaregAge = Animal.AverageAge(animals);
            Console.WriteLine(avaregAge);
        }
    }
}
