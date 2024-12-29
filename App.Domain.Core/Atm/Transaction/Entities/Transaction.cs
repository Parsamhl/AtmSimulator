
using App.Domain.Core.Atm.Card.Entities;


namespace App.Domain.Core.Atm.Transaction.Entities
{
    public class Transaction
    {
        public int TransactionsId { get; set; }

        public int SourceCardNumberId { get; set; }

        public int DestinationCardNumberID { get; set; }

        public float Amount { get; set; }

        public float? Fee { get; set; }

        public DateTime TransactionDate { get; set; }

        public bool IsSuccessful { get; set; }
        public Card.Entities.Card SourceCard { get; set; }
        public Card.Entities.Card DestinationCard { get; set; }
    }
}
