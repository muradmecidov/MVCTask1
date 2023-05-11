using Microsoft.AspNetCore.Mvc;

namespace WebTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
