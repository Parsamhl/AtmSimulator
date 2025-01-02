using App.Domain.Core.Atm.Card.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AtmMVC.Controllers
{
    public class LoginController : Controller
    {
        public readonly ICardAppService _cardAppService;

        public LoginController(ICardAppService cardAppService)
        {
            _cardAppService = cardAppService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
