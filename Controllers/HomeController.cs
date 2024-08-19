using Microsoft.AspNetCore.Mvc;

namespace EBookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
