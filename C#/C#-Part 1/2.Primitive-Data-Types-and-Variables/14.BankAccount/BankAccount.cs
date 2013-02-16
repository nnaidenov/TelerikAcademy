using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Nikolay";
        string middleName = "Tonev";
        string lastName = "Naidenov";
        int balance = 7000;
        char dollars = '\u0024';
        string bankName = "CCB";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        string bicCode = "CECBBGSF";
        ulong creditcardNumber1 = 2548632425489635;
        ulong creditcardNumber2 = 1458965823145862;
        ulong creditcardNumber3 = 1859655781223648;

        Console.WriteLine("Bank account information \n First name: {0} \n Middle name: {1} \n Last name: {2} \n Balance: {3}{4} \n Bank name: {5} \n IBAN: {6} \n BIC Code: {7} \n CreditCard 1 Number: {8} \n CreditCard 2 Number: {9} \n CreditCard 3 Number: {10} \n ",
            firstName, middleName, lastName, balance, dollars, bankName, iban, bicCode, creditcardNumber1, creditcardNumber2, creditcardNumber3);
    }
}