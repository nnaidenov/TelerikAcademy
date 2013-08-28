using System;

class DivideWithoutRemainderCheck
{
    static void Main()
    {
        int a = 70;
        int b = 5;
        int c = 7;
        bool dividedAandB = a%b == 0;
        bool dividedAandC = a%c == 0;

        bool result = dividedAandB && dividedAandC;
        Console.WriteLine(result);
    }
}