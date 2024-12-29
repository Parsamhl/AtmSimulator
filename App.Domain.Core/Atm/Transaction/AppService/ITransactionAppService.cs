using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.Transaction.AppService
{
    public interface ITransactionAppService
    {
        Result.Entitiy.Result TransferMoney(string sCardNumber, string DCardNumber, float amount);
        List<Dtos.TransactionDto> GetTransactionLIst(string cardNumber);
    }
}
