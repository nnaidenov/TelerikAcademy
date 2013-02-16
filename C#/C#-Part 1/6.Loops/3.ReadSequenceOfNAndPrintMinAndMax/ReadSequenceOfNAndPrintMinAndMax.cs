using System;

class ReadSequenceOfNAndPrintMinAndMax
{
    static void Main()
    {
        Console.Write("Колко числа ще въведеш? ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        int biggestNumber = 0;
        int smallestNumber = 1000000000;

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Въведи число: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > biggestNumber)
            {
                biggestNumber = inputNumber;
            }
            else if (inputNumber < smallestNumber)
            {
                smallestNumber = inputNumber;
            }
        }
        Console.WriteLine(biggestNumber);
        Console.WriteLine(smallestNumber);
    }
}