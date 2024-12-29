using App.Domain.Core.Atm.Result.Entitiy;
using App.Domain.Core.Atm.Transaction.AppService;
using App.Domain.Core.Atm.Transaction.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Atm.Transaction
{
    public class TransactionAppService : ITransactionAppService
    {
        public List<TransactionDto> GetTransactionLIst(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public Result TransferMoney(string sCardNumber, string DCardNumber, float amount)
        {
            throw new NotImplementedException();
        }
    }
}
