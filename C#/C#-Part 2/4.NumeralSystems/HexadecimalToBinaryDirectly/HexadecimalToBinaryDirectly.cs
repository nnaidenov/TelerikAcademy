using System;
using System.Collections.Generic;

class HexadecimalToBinaryDirectly
{
    static void Main()
    {
        string hex = "ABC0C";
        Console.Write(hex + "(16) = ");
        List<string> binary = new List<string>();

        for (int i = 0; i < hex.Length; i++)
        {
            int number = (int)hex[i]-48;
            if (hex[i] == 'A')
            {
                binary.Add("1010");
            }
            else if (hex[i] == 'B')
            {
                binary.Add("1011");
            }
            else if (hex[i] == 'C')
            {
                binary.Add("1100");
            }
            else if (hex[i] == 'D')
            {
                binary.Add("1101");
            }
            else if (hex[i] == 'E')
            {
                binary.Add("1110");
            }
            else if (hex[i] == 'F')
            {
                binary.Add("1111");
            }
            else if (hex[i] == '9')
            {
                binary.Add("1001");
            }
            else if (hex[i] == '8')
            {
                binary.Add("1000");
            }
            else if (hex[i] == '7')
            {
                binary.Add("0111");
            }
            else if (hex[i] == '6')
            {
                binary.Add("0110");
            }
            else if (hex[i] == '5')
            {
                binary.Add("0101");
            }
            else if (hex[i] == '4')
            {
                binary.Add("0100");
            }
            else if (hex[i] == '3')
            {
                binary.Add("0011");
            }
            else if (hex[i] == '2')
            {
                binary.Add("0010");
            }
            else if (hex[i] == '1')
            {
                binary.Add("0001");
            }
            else if (hex[i] == '0')
            {
                binary.Add("0000");
            }
        }

        foreach (var a in binary)
        {
            Console.Write(a);
        }
        Console.WriteLine("(2)");
    }
}