using App.Domain.Core.Atm.Transaction.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AtmMVC.Controllers
{
    public class TransactionController : Controller
    {

        private readonly ITransactionAppService _transactionAppService;

        public TransactionController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
