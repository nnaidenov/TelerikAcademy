using System;
using System.Text;

namespace BitArray64Task
{
    class BitTest
    {
        static void Main()
        {
            BitArray bits = new BitArray();

            //Random set of bits
            for (int i = 0; i < 64; i++)
            {
                Random random = new Random();
                StringBuilder getTime = new StringBuilder();
                
                int randomNumber = (int)DateTime.Now.Ticks;

                //Трябва ми време за да се получи добър random
                for (int j = 0; j < 100000; j++)
                {
                    Math.Sqrt(j + 1);
                }
                //Край на губенето на време

                if (randomNumber % 2 == 0)
                {
                    bits[i] = 1;
                }
            }

            Console.WriteLine(bits);

            //Print all Bits
            foreach (var item in bits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
