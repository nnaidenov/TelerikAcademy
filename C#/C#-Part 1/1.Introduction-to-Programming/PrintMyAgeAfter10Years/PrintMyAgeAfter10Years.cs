using System;

class PrintMyAgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter Your Age: "); // Age
        int age = int.Parse(Console.ReadLine()); // Parse int and get user information
        int AfterTenAge = age + 10; // Sum age with 10
        Console.WriteLine("After 10 years you will be " + AfterTenAge + " years old."); // After 10 years
    }
}