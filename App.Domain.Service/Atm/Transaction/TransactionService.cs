using App.Domain.Core.Atm.Transaction.Data.Repository;
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

        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public void Add(Core.Atm.Transaction.Entities.Transaction transaction)
        {
            _transactionRepository.Add(transaction);
        }

        public float DailyWithdrawal(string cardNumber)
        {
            return _transactionRepository.DailyWithdrawal(cardNumber);
        }

        public List<TransactionDto> GetAll(string cardNumber)
        {
            return _transactionRepository.GetAll(cardNumber);
        }
    }
}
