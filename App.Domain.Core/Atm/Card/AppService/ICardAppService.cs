using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.Card.AppService
{
    public interface ICardAppService
    {
        Result.Entitiy.Result PasswordIsValid(string cardNumber, string password);
        string GetCardBalance(string cardNumber);
        void ChangePassword(string cardNumbert, string password, string newPassword);
    }
}
