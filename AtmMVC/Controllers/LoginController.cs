using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Transaction.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AtmMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICardAppService _cardAppService;
        private readonly ITransactionAppService _transactionAppService;


        public LoginController(ICardAppService cardAppService , ITransactionAppService transactionAppService )
        {
            _cardAppService = cardAppService;
            _transactionAppService = transactionAppService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
