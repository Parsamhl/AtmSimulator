using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.Transaction.Data.Repository
{
    public interface ITransactionRepository
    {
        float DailyWithdrawal(string cardNumber);
        void Add(Entities.Transaction transaction);
        List<Dtos.TransactionDto> GetAll(string cardNumber);
    }
}
