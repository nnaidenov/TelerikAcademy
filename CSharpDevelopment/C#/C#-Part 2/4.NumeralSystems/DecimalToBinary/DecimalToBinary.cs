using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        int number = 23353;
        Console.Write(number + "(10) = ");
        List<int> binary = new List<int>();

        while(number != 0)
        {
            binary.Add(number % 2);
            number = number / 2;
        }

        for (int i = binary.Count - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
        
        Console.WriteLine("(2)");
    }
}