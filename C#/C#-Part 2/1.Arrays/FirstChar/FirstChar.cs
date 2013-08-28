using System;

class FirstChar
{
    static void Main()
    {
        char[] array = {'b', 'g'};
        char[] arrayTwo = { 'b', 'a' };
        bool same = true;

        for (int i = 0; i < array.Length; i++)
        {
            if ((int)array[i] < (int)arrayTwo[i]) // Array 1 is First
            {
                Console.WriteLine("First Array is lexicographically First!");
                same = false;
                break;
            }
            else if ((int)array[i] > (int)arrayTwo[i]) // Array 2 is First
            {
                Console.WriteLine("Second Array is lexicographically First!");
                same = false;
                break;
            }
        }
        //Print if Arrays are Same
        if (same)
        {
            Console.WriteLine("Arrays are lexicographically Same!");
        }
    }
}
