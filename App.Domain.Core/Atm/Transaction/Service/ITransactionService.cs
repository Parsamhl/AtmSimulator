using App.Domain.Core.Atm.Transaction.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.Transaction.Service
{
    public interface ITransactionService
    {

        float DailyWithdrawal(string cardNumber);
        void Add(Entities.Transaction transaction);
        List<TransactionDto> GetAll(string cardNumber);
    }
}
