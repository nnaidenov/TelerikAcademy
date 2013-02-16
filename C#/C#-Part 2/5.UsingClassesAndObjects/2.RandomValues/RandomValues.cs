using System;

namespace RandomValues
{
    class RandomValues
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(100, 200);
                Console.WriteLine(a);
            }
        }
    }
}
