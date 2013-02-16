using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine("This is null Int: {0}\nThis is null double: {1}", nullInt, nullDouble);

        nullInt = 5;
        nullDouble = 10.25;

        Console.WriteLine("This is null Int: {0}\nThis is null double: {1}", nullInt, nullDouble);
    }
}