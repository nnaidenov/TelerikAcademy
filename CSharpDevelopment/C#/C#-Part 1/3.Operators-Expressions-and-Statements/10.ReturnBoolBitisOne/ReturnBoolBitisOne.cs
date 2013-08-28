using System;

class ReturnBoolBitisOne
{
    static void Main()
    {
        int v = 235;
        int p = 3;
        int nMask = 1 << p;
        int vAndMask = v & nMask;
        int bit = vAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}