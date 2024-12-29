using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace App.Domain.Core.Atm.Card.Entities
{
    public class Card
    {

        public int ID { get; set; }
        public string CardNumber { get; set; }
        public float Balance { get; set; }
        public bool IsActive { get; set; } = true;
        public string Password { get; set; }
        public User.Entities.User owner { get; set; }
        public int UserID { get; set; }
        public int WrongPassTry { get; set; }

        public List<Transaction.Entities.Transaction> RecivedTransaction { get; set; }
        public List<Transaction.Entities.Transaction> SentTransaction { get; set; }
    }
}
