using App.Domain.Core.Atm.Card.Service;
using App.Domain.Core.Atm.Result.Entitiy;
using App.Domain.Core.Atm.Transaction.AppService;
using App.Domain.Core.Atm.Transaction.Dtos;
using App.Domain.Core.Atm.Transaction.Service;
using App.Domain.Core.Atm.User.Service;


namespace App.Domain.AppService.Atm.Transaction
{
    public class TransactionAppService : ITransactionAppService
    {

        private readonly ITransactionService _transactionService;
        private readonly ICardService _cardService;
        private readonly IUserService _userService;

        public TransactionAppService(ITransactionService transactionService, ICardService cardService, IUserService userService)
        {
            _transactionService = transactionService;
            _cardService = cardService;
            _userService = userService;
        }


        public List<TransactionDto> GetTransactionLIst(string cardNumber)
            => _transactionService.GetAll(cardNumber);

        public Result TransferMoney(string sCardNumber, string DCardNumber, float amount)
        {
            if (DCardNumber.Length != 16)
            {
                return new Result() { IsSuccess = false, Erorr = "Destination Card is not valid" };
            }


            var sCardVail = _cardService.CardIsActive(sCardNumber);
            if (!sCardVail)
            {
                return new Result() { IsSuccess = false, Erorr = "Your Card is not Active !" };
            }


            var dCardValid = _cardService.CardIsActive(DCardNumber);
            if (!dCardValid)
            {
                return new Result() { IsSuccess = false, Erorr = "Destination Card is not Active !" };
            }
            else
            {

                var sCard = _cardService.GetCardBy(sCardNumber);
                var dCard = _cardService.GetCardBy(DCardNumber);


                var recipientName = _userService.GetRecipientName(DCardNumber);
                if (string.IsNullOrEmpty(recipientName))
                {
                    return new Result() { IsSuccess = false, Erorr = "Recipient not found for the provided card number." };
                }


                Console.WriteLine($"Recipient: {recipientName}");


                if (sCard.Balance < amount)
                {
                    return new Result() { IsSuccess = false, Erorr = "Insufficient funds!" };
                }


                if ((_transactionService.DailyWithdrawal(sCardNumber) + amount) > 5000)
                {
                    return new Result() { IsSuccess = false, Erorr = "Daily transfer limit reached!" };
                }


                if (amount > 1000)
                {
                    float fee = (amount * 0.5F) / 100F;
                    sCard.Balance -= fee;
                }
                else if (amount < 1000)
                {
                    float fee = (amount * 1.5F) / 100F;
                    sCard.Balance -= fee;
                }

                _cardService.Whitdraw(sCardNumber, amount);

                try
                {
                    _cardService.Deposite(DCardNumber, amount);
                }
                catch (Exception e)
                {

                    _cardService.Deposite(sCardNumber, amount);
                    return new Result() { IsSuccess = false, Erorr = "Transaction failed. Please try again later." };
                }
                finally
                {

                    var transaction = new Core.Atm.Transaction.Entities.Transaction()
                    {
                        SourceCardNumberId = sCard.ID,
                        DestinationCardNumberID = dCard.ID,
                        Amount = amount,
                        TransactionDate = DateTime.Now,
                        IsSuccessful = true
                    };

                    _transactionService.Add(transaction);
                }

                return new Result() { IsSuccess = true, Erorr = "Transfer successful" };
            }
        }
    }
}

