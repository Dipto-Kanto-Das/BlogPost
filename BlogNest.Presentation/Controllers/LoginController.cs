using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Presentation.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
