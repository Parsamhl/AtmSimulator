using App.Domain.AppService.Atm.Card;

using App.Domain.AppService.Atm.Transaction;
using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Transaction.AppService;
using App.infra.DB.SQLServer;
using Microsoft.AspNetCore.Mvc;


namespace Quiz2.Endpoints.MVC.Controllers
{
    public class TransactionController : Controller
    {

        private readonly ITransactionAppService _transactionAppService;
        private readonly ICardAppService _cardAppService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
       
