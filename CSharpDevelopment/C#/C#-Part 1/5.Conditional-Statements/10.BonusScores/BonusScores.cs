using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Въведи число между 1 и 9.");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1": 
            case "2":
            case "3": int value = int.Parse(input); Console.WriteLine("Вие имате {0} точки.", value * 10); break;
            case "4": 
            case "5":
            case "6": value = int.Parse(input); Console.WriteLine("Вие имате {0} точки.", value * 100); break;
            case "7": 
            case "8":
            case "9": value = int.Parse(input); Console.WriteLine("Вие имате {0} точки.", value * 1000); break;
            default: Console.WriteLine("Грешка"); break;
        }
    }
}