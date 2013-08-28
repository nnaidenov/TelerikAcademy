using System;

class ReadNumbersAndSumIt
{
    static void Main()
    {
        Console.Write("Въведи първото число: ");
        int a =  Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи второто число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведи третото число: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int sum = a + b + c;
        Console.WriteLine(sum);
    }
}