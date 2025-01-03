using App.Domain.Core.Atm.Transaction.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AtmMVC.Controllers
{
    public class TransactionHistoryController : Controller
    {

        private readonly ITransactionAppService _transactionAppService;
        public TransactionHistoryController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
