﻿using App.Domain.Core.Atm.Card.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DataRepo.Ef.Atm.Card
{
    public class CardRepository : ICardRepository
    {
        public bool CardIsActive(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string cardNumber, string password, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ClearWrongPasswordTry(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public void Deposite(string cardNo, float amount)
        {
            throw new NotImplementedException();
        }

        public Domain.Core.Atm.Card.Entities.Card GetCardBy(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public int GetWrongPasswordCount(string cardNo)
        {
            throw new NotImplementedException();
        }

        public bool PasswordIsValid(string cardNumber, string password)
        {
            throw new NotImplementedException();
        }

        public void SetWrongPasswordTry(string cardNo)
        {
            throw new NotImplementedException();
        }

        public void Whitdraw(string cardNo, float amount)
        {
            throw new NotImplementedException();
        }
    }
}