using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class CheckMoney
    {
        private string insertedCoin;
        private decimal totalAmount;

        public string InsertedCoin
        {
            get { return this.insertedCoin; }
            set { this.insertedCoin = value; }
        }

        public decimal TotalAmount
        {
            get { return this.totalAmount; }
            set { this.totalAmount = value; }
        }

        public static decimal CheckCoin(string insertedCoin, decimal totalAmount)
        {
            string coin = insertedCoin.ToString();
            switch (insertedCoin)
            {
                case "0.10": totalAmount += Convert.ToDecimal(insertedCoin); break;
                case "0.20": totalAmount += Convert.ToDecimal(insertedCoin); break;
                case "0.50": totalAmount += Convert.ToDecimal(insertedCoin); break;
                case "1.00": totalAmount += Convert.ToDecimal(insertedCoin); break;
                default:
                    string message = string.Format("{0} is not a valid coin", coin);
                    throw new CoinException(message);
            }
            return totalAmount;
        }
    }
}
