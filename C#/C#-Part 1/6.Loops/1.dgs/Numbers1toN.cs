using System;

class Numbers1toN
{
    static void Main()
    {
        Console.Write("Въведи числото до което да броим: ");
        int numberN = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}