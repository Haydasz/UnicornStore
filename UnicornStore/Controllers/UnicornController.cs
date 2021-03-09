using Microsoft.AspNetCore.Mvc;

namespace UnicornStore.Controllers
{
    public class UnicornController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }
    }
}