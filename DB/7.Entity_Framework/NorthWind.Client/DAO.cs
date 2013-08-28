using System;
using System.Linq;
using NorthWind.Data;
using System.Collections.Generic;
using System.Transactions;
using Wintellect.PowerCollections;

namespace NorthWind.Client
{
    public class DAO
    {
        //2.Create a DAO class with static methods which provide functionality for inserting,
        //  modifying and deleting customers. Write a testing class
        public void InsertCustomer(
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax)
        {
            var db = new NORTHWNDEntities();
            using (db)
            {
                Customer myCustomer = new Customer();
                myCustomer.Address = address;
                myCustomer.City = city;
                myCustomer.CompanyName = companyName;
                myCustomer.ContactName = contactName;
                myCustomer.ContactTitle = contactTitle;
                myCustomer.Country = country;
                myCustomer.Fax = fax;
                myCustomer.Phone = phone;
                myCustomer.Region = region;
                myCustomer.PostalCode = postalCode;

                string cusId = contactName.Substring(0, 5);
                myCustomer.CustomerID = cusId;

                db.Customers.Add(myCustomer);
                db.SaveChanges();
            }
        }

        public void DeleteCustomer(string customerName)
        {
            var db = new NORTHWNDEntities();

            using (db)
            {
                var customer = db.Customers.Where(x => x.CompanyName == customerName).First();
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        public void UpdateCustomer(
            string oldName,
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax)
        {
            var db = new NORTHWNDEntities();
            using (db)
            {
                var customer = db.Customers.Where(x => x.CompanyName == oldName).First();
                customer.Address = address;
                customer.City = city;
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                customer.ContactTitle = contactTitle;
                customer.Country = country;
                customer.Fax = fax;
                customer.Phone = phone;
                customer.Region = region;
                customer.PostalCode = postalCode;

                string cusId = contactName.Substring(0, 5);
                customer.CustomerID = cusId;

                db.SaveChanges();
            }
        }

        public void FindCustomer(string customerName)
        {
            var db = new NORTHWNDEntities();

            using (db)
            {
                var customer = db.Customers.Where(x => x.CompanyName == customerName).First();

                Console.WriteLine(customer.CompanyName);
            }
        }

        //3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada
        public void FindCustomerByYear()
        {
            var db = new NORTHWNDEntities();
            using (db)
            {
                DateTime time = new DateTime(1997, 1, 1);
                var customers = db.Orders.Where(x => x.OrderDate.Value.Year == time.Year).Where(x => x.ShipCountry == "Canada");

                foreach (var customer in customers.Distinct())
                {
                    Console.WriteLine(customer.Customer.CompanyName);
                }
            }
        }

        //4.Implement previous by using native SQL query and executing it through the DbContext.
        public void FindCustomerByYearSql()
        {
            var db = new NORTHWNDEntities();
            using (db)
            {
                string query = @"SELECT DISTINCT CompanyName FROM Customers c 
                             JOIN Orders o 
	                           ON o.CustomerID = c.CustomerID 
                             WHERE o.ShipCountry = 'Canada' AND YEAR(o.OrderDate) = '1997'";

                var queryResult = db.Database.SqlQuery<string>(query);

                foreach (var res in queryResult)
                {
                    Console.WriteLine(res);
                }
            }
        }

        //5.Write a method that finds all the sales by specified region and period (start / end dates).
        public void FindSales(string region, DateTime minDate, DateTime maxDate)
        {
            var db = new NORTHWNDEntities();
            
            using (db)
            {
                var sales = db.Orders.Where(x => x.ShipRegion == region).
                    Where(x => x.ShippedDate > minDate).
                    Where(x => x.ShippedDate < maxDate);

                foreach (var sale in sales)
                {
                    Console.WriteLine(sale.ShippedDate + " " + sale.ShipRegion);
                }
            }
        }

        //7.Try to open two different data contexts and perform concurrent changes on the same records. 
        //What will happen at SaveChanges()? How to deal with it?
        public void CheckConcurrent()
        {
            var db = new NORTHWNDEntities();
            var db2 = new NORTHWNDEntities();

            var region = db.Regions.Find(5);
            region.RegionDescription = "Burgas";
            
            db.SaveChanges();
            Console.WriteLine("Updated");
            var region2 = db.Regions.Find(5);
            db2.Regions.Remove(region2);
            db2.SaveChanges();
            Console.WriteLine("Deleted");
        }


        //9.Create a method that places a new order in the Northwind database. 
        //The order should contain several order items. Use transaction to ensure the data consistency.
        public void MakeOrder(Order myOrder, List<Tuple<int, int, int>> items)
        {
            var db = new NORTHWNDEntities();

            using (db)
            {
                using(TransactionScope scope = new TransactionScope())
                {
                    var newOrder = db.Orders.Add(myOrder);

                    foreach (var item in items)
                    {
                        Order_Detail myDetail = new Order_Detail
                        {
                            OrderID = newOrder.OrderID,
                            ProductID = item.Item1,
                            Quantity = (short)item.Item2,
                            UnitPrice = (short)item.Item3
                        };

                        db.Order_Details.Add(myDetail);
                    }

                    try
                    {
                        db.SaveChanges();
                        scope.Complete();
                        Console.WriteLine("OK");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rollback!!");
                        scope.Dispose();
                    }
                }
             
            }
        }

        //10.Create a stored procedures in the Northwind database for finding the total incomes for 
        //given supplier name and period (start date, end date). Implement a C# method that calls 
        //the stored procedure and returns the retuned record set.
        public void CalculateIncoms(string supplierName, DateTime minDate, DateTime maxDate)
        {
            var db = new NORTHWNDEntities();
            
            using (db)
            {
                //Execute first USP.sql
                var result = db.usp_FindTotalIncome(minDate.Year, maxDate.Year, supplierName);
                Console.WriteLine(result.FirstOrDefault());
            }
        }

    }
}
