﻿using System;

class ShowsTheNameOfThatDigit
{
    static void Main()
    {
        Console.Write("Напишете число между 0 и 10, за да разберете как се пише на Английски.");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 10: Console.WriteLine("Ten"); break;
            default: Console.WriteLine("Your Number is bigger than 10!"); break;
        }
    }
}