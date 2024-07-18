using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
