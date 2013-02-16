using System;

class compareArray
{
    static void Main()
    {
        int[] array = new int[5];
        int[] arrayTwo = new int[5];
        bool same = true;

        //Input FirstArray
        //int[] array = { 0, 3, 1, 1, 3, 0, 5, 6 };
        Console.WriteLine("Write 5 integer for First Array.");
        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //Input SecondArray
        //int[] arrayTwo = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1 };
        Console.WriteLine("Write 5 integer for Second Array.");
        for (int i = 0; i < 5; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }

        //Compare Arrays
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != arrayTwo[i])
            {
                same = false;
                break;
            }
        }

        //Print output
        if (same)
        {
            Console.WriteLine("Arrays are the Same!");
        }
        else {
            Console.WriteLine("Arrays are Difference!");
        }
    }
}
