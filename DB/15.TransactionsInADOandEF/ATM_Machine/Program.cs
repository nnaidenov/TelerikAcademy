using System;
using System.Collections.Generic;
using System.Linq;
using ATM.Models;
using ATM.Data;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ATM_Data.Migrations;

namespace ATM.Client
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());

            string cardNumber = "2563145851";
            string cardPin = "1235";
            decimal cash = 250;

            CardAccount myAccout = new CardAccount(cardNumber, cardPin, cash);
            var db = new ATMContext();

            RetrievesMoney(db);
        }

        public static void AddCardAccount(CardAccount newAccount, ATMContext context)
        {
            context.CardAccounts.Add(newAccount);
            context.SaveChanges();
            Console.WriteLine("Correct added!");
        }

        public static void RetrievesMoney(ATMContext db)
        {
            Console.WriteLine("Enter card number:");
            string cNumber = Console.ReadLine();

            Console.WriteLine("Enter PIN:");
            string pin = Console.ReadLine();

            Console.WriteLine("Enter money:");
            decimal money = decimal.Parse(Console.ReadLine());

            using (db)
            {
                using (var tran = new TransactionScope())
                {

                    var firstCheck = db.CardAccounts.Where(x => x.Number == cNumber).Where(x => x.PIN == pin);

                    if (firstCheck.Count() != 1)
                    {
                        tran.Dispose();
                        Console.WriteLine("More");
                    }
                    else
                    {
                        var a = db.CardAccounts.Where(x => x.Number == cNumber).First();

                        if (a.Cash >= money)
                        {
                            try
                            {
                                a.Cash -= money;
                                db.SaveChanges();
                                tran.Complete();
                                Console.WriteLine("OK");
                                AddToHistory(cNumber, DateTime.Now, money, db);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                                tran.Dispose();
                                Console.WriteLine("No");
                            }
                        }
                    }
                }
            }
        }

        private static void AddToHistory(string cNumber, DateTime transactionTime, decimal money, ATMContext db)
        {
            using (db)
            {
                using (var tran = new TransactionScope())
                {
                    var history = new TransactionsHistory(cNumber, transactionTime, money);
                    db.TransactionsHistories.Add(history);
                    db.SaveChanges();
                    tran.Complete();
                    Console.WriteLine("added");
                }
            }
        }
    }
}
