using Microsoft.AspNetCore.Mvc;

namespace UnicornStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}