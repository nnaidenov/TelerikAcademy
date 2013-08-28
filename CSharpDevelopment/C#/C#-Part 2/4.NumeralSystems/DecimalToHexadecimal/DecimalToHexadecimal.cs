using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        int num = 11259375;
        List<int> hex = new List<int>();

        Console.Write(num + "(10) = ");

        while (num != 0)
        {
            hex.Add(num % 16);
            num /= 16;
        }

        for (int i = hex.Count-1; i >= 0; i--)
        {
            if (hex[i] == 10)
            {
                Console.Write("A");
            }
            else if (hex[i] == 11)
            {
                Console.Write("B");
            }
            else if (hex[i] == 12)
            {
                Console.Write("C");
            }
            else if (hex[i] == 13)
            {
                Console.Write("D");
            }
            else if (hex[i] == 14)
            {
                Console.Write("E");
            }
            else if (hex[i] == 15)
            {
                Console.Write("F");
            }
            else
            {
                Console.Write(hex[i]);
            }     
        }
        Console.Write("(16)");
        Console.WriteLine();
    }
}