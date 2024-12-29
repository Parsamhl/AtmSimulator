using App.Domain.Core.Atm.Transaction.Dtos;
using App.Domain.Core.Atm.Transaction.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Atm.Transaction
{
    public class TransactionService : ITransactionService
    {
        public void Add(Core.Atm.Transaction.Entities.Transaction transaction)
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
