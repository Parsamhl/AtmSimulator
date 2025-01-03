using App.Domain.AppService.Atm.Card;
using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Card.Entities;

using Microsoft.AspNetCore.Mvc;

namespace Quiz2.Endpoints.MVC.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardAppService _cardAppService;

        public CardController(ICardAppService cardAppService)
        {
            _cardAppService = cardAppService;
        }
        public IActionResult Index()
        {
                return View();
        }
       

        public IActionResult GetBalance(string cardNumber)
        {     
                var balance = _cardAppService.GetCardBalance(cardNumber);
                return View(balance);

        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginCard(string cardNumber, string password)
        {
            _cardAppService.PasswordIsValid(cardNumber, password);
            return RedirectToAction("Index", "Home");
        }
     

        public IActionResult ChangePasswordCard(string cardNumber ,string password , string newPassword)
        {
                _cardAppService.ChangePassword(cardNumber , password , newPassword);
                return RedirectToAction("Index", "Home");
        }

    }
}
