using System;
using System.Data.Entity;
using System.Linq;
using ATM.Models;

namespace ATM.Data
{
    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATMContextDBCon")
        {

        }

        public DbSet<CardAccount> CardAccounts { get; set; }

        public DbSet<TransactionsHistory> TransactionsHistories { get; set; }
    }
}
