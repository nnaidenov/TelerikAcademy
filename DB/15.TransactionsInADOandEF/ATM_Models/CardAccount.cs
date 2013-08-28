using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class CardAccount
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        [Required]
        [StringLength(4)]
        public string PIN { get; set; }

        [Required]
        public decimal Cash { get; set; }

        public CardAccount()
        {
        }

        public CardAccount(string cardNumber, string cardPin, decimal cardCash)
        {
            this.Number = cardNumber;
            this.PIN = cardPin;
            this.Cash = cardCash;
        }
    }
}
