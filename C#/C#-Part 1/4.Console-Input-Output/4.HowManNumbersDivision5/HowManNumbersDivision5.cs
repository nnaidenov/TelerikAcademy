using System;

class HowManNumbersDivision5
{
    static void Main()
    {
        Console.Write("Въведете a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведете b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int howmany = 0;

        if (a <= b)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    howmany++;
                }
            }
            Console.WriteLine(howmany);
        }
        else 
        {
            Console.WriteLine("Не може b да е по-малко от а!");
        }
    }
}