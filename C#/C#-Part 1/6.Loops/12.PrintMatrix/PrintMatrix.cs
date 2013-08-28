using System;

class PrintMatrix
{
    static void Main()
    {
        Console.WriteLine("Въведи N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 1+count; j < n+count+1; j++)
            {
                Console.Write("{0:00} ", j);
            }
            count++;
            Console.WriteLine();
        }
    }
}