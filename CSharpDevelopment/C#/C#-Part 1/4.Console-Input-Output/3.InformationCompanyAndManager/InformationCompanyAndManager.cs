using System;

class InformationCompanyAndManager
{
    static void Main()
    {
        Console.Write("Company name: ");
        string cName = Console.ReadLine();
        Console.Write("Company address: ");
        string cAddress = Console.ReadLine();
        Console.Write("Company phone: ");
        string cPhone = Console.ReadLine();
        Console.Write("Company fax: ");
        string cFax = Console.ReadLine();
        Console.Write("Company web site: ");
        string cWebSite = Console.ReadLine();
        Console.Write("Company's manager: ");
        string cManager = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Информация за компанията");
        Console.WriteLine("|Името на компанията е:      |{0,-40} |", cName);
        Console.WriteLine("|Адреса на компанията е:     |{0,-40} |", cAddress);
        Console.WriteLine("|Телефона на компанията е:   |{0,-40} |", cPhone);
        Console.WriteLine("|Факса на компанията е:      |{0,-40} |", cFax);
        Console.WriteLine("|Сайта на компанията е:      |{0,-40} |", cWebSite);
        Console.WriteLine("|Мениджъра на компанията е:  |{0,-40} |", cManager);

        Console.WriteLine();

        int mAge = 20;
        string mPhoneNumber = "0883658944";

        Console.WriteLine("Информация за мениджъра");
        Console.WriteLine("|Име:             |{0,30} |", cManager);
        Console.WriteLine("|Възраст:         |{0,30} |", mAge);
        Console.WriteLine("|Телефонен номер: |{0,30} |", mPhoneNumber);
    }
}