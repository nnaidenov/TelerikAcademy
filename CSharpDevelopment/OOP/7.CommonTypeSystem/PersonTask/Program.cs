using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.name = "Asdf Asdfov";

            Console.WriteLine(newPerson);
        }
    }
}
