using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Presentation.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
