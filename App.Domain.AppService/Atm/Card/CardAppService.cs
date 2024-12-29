using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Card.Data.Repository;
using App.Domain.Core.Atm.Result.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Atm.Card
{
    public class CardAppService : ICardAppService
    {
        private readonly ICardRepository _cardRepository;

        public CardAppService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public void ChangePassword(string cardNumbert, string password, string newPassword)
        {
            throw new NotImplementedException();
        }

        public string GetCardBalance(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public Result PasswordIsValid(string cardNumber, string password)
        {
            throw new NotImplementedException();
        }
    }
}
