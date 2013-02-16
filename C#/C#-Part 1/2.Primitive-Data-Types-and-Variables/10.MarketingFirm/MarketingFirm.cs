using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName = "Nikolay";
        string familyName = "Naidenov";
        sbyte age = 20;
        char gender = '\u006d';
        int idNumber = 27560578;

        Console.WriteLine("Information about employeе:\n\r First Name: {0}\n\r Family Name: {1}\n\r Age: {2}\n\r Gender: {3}\n\r ID Number: {4}",
            firstName, familyName, age, gender, idNumber);
    }
}