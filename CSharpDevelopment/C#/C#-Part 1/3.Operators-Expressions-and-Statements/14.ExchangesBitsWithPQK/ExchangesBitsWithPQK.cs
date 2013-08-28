using System;

class BitSwitchCustomize
{
    static void Main()
    {
        int n = 2083520632;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int p = 3; // Битове от позиции 3+к
        int q = 23; // Битовете от позиции 23+к
        int k = 2; // Колко бита

        for(int i = p, j = q; i < p+k-1; i++, j++)
        {
            int maskSMall = 1 << i;
            int maskBig = 1 << j;
            int smallBit = maskSMall & n;
            int bigBit = maskBig & n;

            if (smallBit == 0)
            {
                int changer = 1 << j;
                n = (n & ~changer);
            }
            else
            {
                int changer = 1 << j;
                n = (n | changer);
            }
 
            if (bigBit == 0)
            {
                int changer = 1 << i;
                n = (n & ~changer);
            }
            else
            {
                int changer = 1 << i;
                n = (n | changer);
            }
        }
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}