using System;

class IsPrimeNumber
{
    static void Main()
    {
        Console.Write("Въведете число между 1 и 100: ");
        int n = int.Parse(Console.ReadLine());
        int p = 0;
        if ((n > 0) && (n <= 100))
        {
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    p = p + 1;
                }
                else
                {
                    p = p + 0;
                }
            }
            if (p == 1)
            {
                Console.WriteLine("Просто");
            }
            else
            {
                Console.WriteLine("Сложно");
            }
        }
        else
        {
            Console.WriteLine("Числото, което сте въвели не е в разрешените граници!");
        }
    }
}