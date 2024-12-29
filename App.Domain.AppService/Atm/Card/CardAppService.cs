using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Card.Data.Repository;
using App.Domain.Core.Atm.Card.Service;
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
        private readonly ICardService _cardService;

        public CardAppService(ICardService cardService)
        {
            _cardService = cardService;
        }

        public void ChangePassword(string cardNumbert, string password, string newPassword)
        {
            var card = _cardService.GetCardBy(cardNumbert);
            if (password == card.Password)
            {
                card.Password = newPassword;
                _cardService.ChangePassword(cardNumbert, password, newPassword);
            }
        }

        public string GetCardBalance(string cardNumber)
        {
            var card = _cardService.GetCardBy(cardNumber);
            if (card is null)
            {
                return "404";
            }
            else
            {
                return $"your card balance : {card.Balance}";
            }
        }

        public Result PasswordIsValid(string cardNumber, string password)
        {
            var count = _cardService.GetWrongPasswordCount(cardNumber);

            if (count > 3)
            {
                return new Result() { IsSuccess = false, Erorr = "wrong password attemp limit reached" };
            }
            var passwordValid = _cardService.PasswordIsValid(cardNumber, password);
            if (passwordValid == false)
            {
                return new Result() { IsSuccess = false, Erorr = "Password is incorrect!" };
            }
            else
            {
                _cardService.ClearWrongPasswordTry(cardNumber);
                return new Result() { IsSuccess = true, Erorr = "Welcome!" };
            }
        }
    }
}
