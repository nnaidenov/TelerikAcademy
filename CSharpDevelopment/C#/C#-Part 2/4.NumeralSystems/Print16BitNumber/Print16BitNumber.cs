using System;
using System.Collections.Generic;

class Print16BitNumber
{
    static void Main()
    {
        int number = -125;
        bool isPrime = false;
        bool isNegative = false;
        int[] binary = new int[16];
        int possition = int.MaxValue;
        int i = 0;

        Console.Write(number + "(10) = ");

        if (number < 0)
        {
            isNegative = true;
        }

        if (Math.Abs(number) % 2 == 1)
        {
            isPrime = true;
        }

        while (number != 0)
        {

            binary[i] = Math.Abs(number) % 2;
            if (Math.Abs(number) % 2 == 1)
            {
                if (possition > i)
                {
                    possition = i;
                }
            }
            number = Math.Abs(number) / 2;
            i++;
        }

        if (isNegative)
        {
            for (int f = 0; f < 16; f++)
            {
                binary[f] = binary[f] ^ 1;
            }

            if (!isPrime)
            {
                binary[possition] = 1;
                for (int l = 0; l < possition; l++)
                {
                    binary[l] = 0;
                }
            }
        }
        if (isPrime)
        {
            binary[0] = 1;
        }
        else
        {
            binary[0] = 0;
        }

        for (int j = 15; j >= 0; j--)
        {
            Console.Write(binary[j]);
        }

        Console.WriteLine("(2)");
    }
}