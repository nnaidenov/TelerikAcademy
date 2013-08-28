using System;

class SetBitOnPosition
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(5, '0'));
        Console.Write("Въведете позиция: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Въведете стойност на бита 1 или 0: ");
        int v = int.Parse(Console.ReadLine());

        if (p >= 0 && (v == 1 || v == 0))
        {
            if (v == 1)
            {// set 1
                int mask = 1 << p;
                int bit = n | mask;
                Console.WriteLine(Convert.ToString(bit, 2).PadLeft(5 + p, '0'));
            }
            else
            {// set 0
                int mask = ~(1 << p);
                int bit = n & mask;
                Console.WriteLine(Convert.ToString(bit, 2).PadLeft(5 + p, '0'));
            }
        }
        else
        {
            Console.WriteLine("Въвели сте некоректни данни!");
        }
    }
}
