﻿using App.Domain.Core.Atm.Card.Data.Repository;
using App.infra.DB.SQLServer.Atm.DataBase;


namespace App.infra.DataRepo.Ef.Atm.Card
{
    public class CardRepository : ICardRepository
    {
        private readonly AppDbContext _context;

        public CardRepository()
        {
            _context = new AppDbContext();
        }

        public bool CardIsActive(string cardNumber)
        => _context.cards.Any(c => c.CardNumber == cardNumber && c.IsActive == true);

        public void ChangePassword(string cardNumber, string password, string newPassword)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNumber && c.Password == password);
            if (card is null)
            {
                throw new Exception("invalid card");
            }
            else
            {
                newPassword = card.Password;
                _context.SaveChanges();
            }
        }

        public void ClearWrongPasswordTry(string cardNumber)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNumber);
            if (card is null)
            {
                throw new Exception("Invalid card");

            }
            if (card.WrongPassTry != 0)
            {
                card.WrongPassTry = 0;
                _context.SaveChanges();
            }
        }

        public void Deposite(string cardNo, float amount)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNo);
            if (card is null)
            {
                throw new Exception("invalid card");

            }
            else
            {
                card.Balance += amount;
                _context.SaveChanges();
            }
        }

        public Domain.Core.Atm.Card.Entities.Card GetCardBy(string cardNumber)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNumber);

            //_context.Entry(card).Reload();
            if (card == null)
            {
                throw new Exception($"card by number bot found {cardNumber}");
            }
            else
            {
                return card;
            }
        }

        public int GetWrongPasswordCount(string cardNo)
        {
            var card = _context.cards.FirstOrDefault(x => x.CardNumber == cardNo);

            if (card is null)
            {
                throw new Exception($"invalid card !");
            }

            return card.WrongPassTry;
        }

        public bool PasswordIsValid(string cardNumber, string password)
         => _context.cards.Any(c => c.CardNumber == cardNumber && c.Password == password);

        public void SetWrongPasswordTry(string cardNo)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNo);
            if (card is null)
            {
                throw new Exception($"invalid Card number{cardNo} ");
            }
            else
            {
                card.WrongPassTry++;
                _context.SaveChanges();
            }
        }

        public void Whitdraw(string cardNo, float amount)
        {
            var card = _context.cards.FirstOrDefault(c => c.CardNumber == cardNo);

            if (card is null)
            {
                throw new Exception("Invalid Card");

            }
            else
            {
                card.Balance -= amount;
                _context.SaveChanges();
            }
        }
    }
}
