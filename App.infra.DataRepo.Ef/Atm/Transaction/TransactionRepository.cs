using App.Domain.Core.Atm.Transaction.Data.Repository;
using App.Domain.Core.Atm.Transaction.Dtos;
using App.infra.DB.SQLServer.Atm.DataBase;


namespace App.infra.DataRepo.Ef.Atm.Transaction
{
    public class TransactionRepository : ITransactionRepository
    {

        private readonly AppDbContext _context;

        public TransactionRepository()
        {
            _context = new AppDbContext();

        }
        public void Add(Domain.Core.Atm.Transaction.Entities.Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public float DailyWithdrawal(string cardNumber)
        {
            var amountOfTransactions = _context.Transactions
            .Where(x => x.TransactionDate.Date == DateTime.Now.Date && x.SourceCard.CardNumber == cardNumber)
            .Sum(x => x.Amount);

            return amountOfTransactions;

        }

        public List<TransactionDto> GetAll(string cardNumber)
        {
            return _context.Transactions
              .Where(x => x.SourceCard.CardNumber == cardNumber || x.DestinationCard.CardNumber == cardNumber)
              .Select(x => new TransactionDto
              {
                  SourceCardNumber = x.SourceCard.CardNumber,
                  DestinationsCardNumber = x.DestinationCard.CardNumber,
                  TransavtionDate = x.TransactionDate,
                  Amount = x.Amount,
                  IsSuccess = x.IsSuccessful,

              }).ToList();


        }
    }
}
