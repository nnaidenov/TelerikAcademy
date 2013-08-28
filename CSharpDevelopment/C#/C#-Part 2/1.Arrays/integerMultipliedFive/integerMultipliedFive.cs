using System;

class integerMultipliedFive
{
    static void Main()
    {
        int[] array = new int[20];

        //Multiplied By 5
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        //Print Array
        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}
