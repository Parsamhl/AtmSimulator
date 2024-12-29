using App.Domain.Core.Atm.Card.Data.Repository;
using App.Domain.Core.Atm.Card.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Atm.Card
{
    public class CardService : ICardService
    {

        private readonly ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public bool CardIsActive(string cardNumber)
        {
            return _cardRepository.CardIsActive(cardNumber);
        }

        public void ChangePassword(string cardNumber, string password, string newPassword)
        {
            _cardRepository.ChangePassword(cardNumber, password, newPassword);
        }

        public void ClearWrongPasswordTry(string cardNumber)
        {
            _cardRepository.ClearWrongPasswordTry(cardNumber);
        }

        public void Deposite(string cardNo, float amount)
        {
            _cardRepository.Deposite(cardNo, amount);
        }

        public Core.Atm.Card.Entities.Card GetCardBy(string cardNumber)
        {
            return _cardRepository.GetCardBy(cardNumber);
        }

        public int GetWrongPasswordCount(string cardNo)
        {
            return _cardRepository.GetWrongPasswordCount(cardNo);
        }

        public bool PasswordIsValid(string cardNumber, string password)
        {
            return _cardRepository.PasswordIsValid(cardNumber, password);
        }

        public void SetWrongPasswordTry(string cardNo)
        {
            _cardRepository.SetWrongPasswordTry(cardNo);
        }

        public void Whitdraw(string cardNo, float amount)
        {
            _cardRepository.Whitdraw(cardNo, amount);
        }
    }
}
