using System;

class GivenBitValue
{
    static void Main()
    {
        int i = 1232;
        int b = 4;
        int m = 1;
        int mask = m << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine(bit);
    }
}
