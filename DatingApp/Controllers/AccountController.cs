using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
