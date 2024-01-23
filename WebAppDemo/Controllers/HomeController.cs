using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
