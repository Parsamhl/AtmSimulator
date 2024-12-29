

namespace App.Domain.Core.Atm.Card.Data.Repository
{
    public interface ICardRepository
    {

        bool PasswordIsValid(string cardNumber, string password);
        void Whitdraw(string cardNo, float amount);
        void Deposite(string cardNo, float amount);
        void SetWrongPasswordTry(string cardNo);
        int GetWrongPasswordCount(string cardNo);
        bool CardIsActive(string cardNumber);
        Entities.Card GetCardBy(string cardNumber);
        void ClearWrongPasswordTry(string cardNumber);
        void ChangePassword(string cardNumber, string password, string newPassword);
    }
}
