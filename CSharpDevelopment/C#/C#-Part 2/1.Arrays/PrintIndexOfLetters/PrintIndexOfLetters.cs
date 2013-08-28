using System;

class PrintIndexOfLetters
{
    static void Main()
    {
        char[] array = new char[26];

        //Fill Array with Letters
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)(i + 65);
        }

        string word = Console.ReadLine();
        Console.WriteLine();

        //Print Letters and Index
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (word[i] == array[j])
                {
                    Console.WriteLine("{0}-{1}", array[j], j);
                }
                
            }
        }
    }
}