using App.Domain.Core.Atm.Transaction.Data.Repository;
using App.Domain.Core.Atm.Transaction.Dtos;


namespace App.infra.DataRepo.Ef.Atm.Transaction
{
    public class TransactionRepository : ITransactionRepository
    {
        public void Add(Domain.Core.Atm.Transaction.Entities.Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public float DailyWithdrawal(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public List<TransactionDto> GetAll(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
