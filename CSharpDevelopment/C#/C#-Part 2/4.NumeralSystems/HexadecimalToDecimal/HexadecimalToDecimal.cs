using System;

class BinaryToDecimal
{
    static void Main()
    {
        string hex = "1F4";
        int decNum = 0;

        Console.Write(hex + " (16) = ");

        for (int i = hex.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (hex[i] == 'A')
            {
                int curNum = 10 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else if (hex[i] == 'B')
            {
                int curNum = 11 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else if (hex[i] == 'C')
            {
                int curNum = 12 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else if (hex[i] == 'D')
            {
                int curNum = 13 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else if (hex[i] == 'E')
            {
                int curNum = 14 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else if (hex[i] == 'F')
            {
                int curNum = 15 * (int)Math.Pow(16, j);
                decNum += curNum;
            }
            else
            {
                int curNum = ((int)hex[i]-48) * (int)Math.Pow(16, j);
                decNum += curNum;
            }
        }
        Console.WriteLine(decNum + " (10)");
    }
}