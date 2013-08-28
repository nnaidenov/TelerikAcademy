using System;

class SumNNumbers
{
    static void Main()
    {
        Console.Write("Колко числа искате да съберете? ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Въведи число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            sum = sum +number;
        }
        Console.WriteLine("Сумата на избраните от вас числа е: {0}", sum);
    }
}