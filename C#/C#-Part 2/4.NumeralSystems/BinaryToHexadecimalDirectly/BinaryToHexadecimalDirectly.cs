using System;
using System.Collections.Generic;

class BinaryToHexadecimalDirectly
{
    static void Main()
    {
        string binaryRev = "0100001111010101";
        string binary = "";
        for (int i = binaryRev.Length - 1; i >= 0; i--)
        {
            binary += binaryRev[i];
        }
        int posNum = 0;
        int[] transform = new int[4];
        List<char> hex = new List<char>();

        while (binary.Length > 0)
        {
            for (int i = binary.Length - 4, j = 0; i <= binary.Length - 1; i++, j++)
            {
                transform[j] = (int)binary[i] - 48;
            }

            for (int i = 0; i < 4; i++)
            {
                int curNum = transform[i] * (int)Math.Pow(2, i);
                posNum += curNum;
            }

            if (posNum == 10)
            {
                hex.Add('A');
            }
            else if (posNum == 11)
            {
                hex.Add('B');
            }
            else if (posNum == 12)
            {
                hex.Add('C');
            }
            else if (posNum == 13)
            {
                hex.Add('D');
            }
            else if (posNum == 14)
            {
                hex.Add('E');
            }
            else if (posNum == 15)
            {
                hex.Add('F');
            }
            else
            {
                hex.Add((char)(posNum + 48));
            }

            binary = binary.Remove(binary.Length - 4);
            posNum = 0;
        }

        Console.Write(binaryRev + "(2) = ");
        foreach (var finalNum in hex)
        {
            Console.Write(finalNum);
        }
        Console.WriteLine("(16)");
    }
}