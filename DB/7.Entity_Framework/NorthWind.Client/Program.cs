using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Data;

namespace NorthWind.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO controller = new DAO();

            //controller.InsertCustomer("Billa", "Nikolay Naidenov", "Owner", "Some address", "Kaspichan", "BG", "1000", "Bulgaria", "0881258965", "5863214585");
            //controller.FindCustomer("Billa");
            //controller.UpdateCustomer("Billa", "Billa2", "Nikolay Naidenov", "Owner", "Some address", "Kaspichan", "BG", "1000", "Bulgaria", "0881258965", "5863214585");
            //controller.FindCustomer("Billa2");
            //controller.DeleteCustomer("Billa2");
            //controller.FindCustomerByYear();
            //controller.FindCustomerByYearSql();

            string region = "WA";
            DateTime minDate = new DateTime(1997, 1, 1);
            DateTime maxDate = new DateTime(1997, 12, 31);
            //controller.FindSales(region, minDate, maxDate);

            string companyName = "Exotic Liquids";
            //controller.CalculateIncoms(companyName, minDate, maxDate);
            //controller.CheckConcurrent();

            Order myOrder = new Order
            {
                CustomerID = "VINET",
                OrderDate = DateTime.Now,
                ShipAddress = "Sofia"
            };
            Tuple<int, int, int> firstProduct = new Tuple<int, int, int>(2, 523, 25);
            //Tuple<int, int, int> firstProduct = new Tuple<int, int, int>(19999999, 523, 25); //RollBack
            Tuple<int, int, int> secondProduct = new Tuple<int, int, int>(3, 601, 26);

            List<Tuple<int, int, int>> itemsList = new List<Tuple<int, int, int>>() 
            {
                firstProduct,
                secondProduct
            };

            //controller.MakeOrder(myOrder, itemsList);
        }
    }
}
