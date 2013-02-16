using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = "101101100111001";
        int decNum = 0;

        for (int i = binary.Length-1, j =0; i >= 0 ; i--, j++)
        {
            if ((int)binary[i] == '1')
            {
                int posNum = 1 * (int)Math.Pow(2, j);
                decNum += posNum;
            }
            else
            {
                int posNum = 0 * (int)Math.Pow(2, i);
                decNum += posNum;
            }
        }
        Console.WriteLine(binary + "(2) = " + decNum + " (10)");
    }
}