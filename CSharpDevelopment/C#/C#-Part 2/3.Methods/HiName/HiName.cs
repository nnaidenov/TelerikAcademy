using System;

namespace HiName
{
    class HiName
    {
        static void Main()
        {
            string name = Console.ReadLine();

            SayHello(name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
