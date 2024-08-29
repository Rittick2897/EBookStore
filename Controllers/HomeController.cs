using Microsoft.AspNetCore.Mvc;

namespace EBookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewReleases()
        {
            return View();
        }

        public IActionResult BestSellers()
        {
            return View();
        }
    }
}
