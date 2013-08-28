using System;

class OddOrEven
{
    static void Main()
    {
        int a = 6;
        int residue = a % 2;
        if (residue == 0)
        {
            Console.WriteLine("Четно");
        }
        else
        {
            Console.WriteLine("Нечетно");
        }
    }
}
