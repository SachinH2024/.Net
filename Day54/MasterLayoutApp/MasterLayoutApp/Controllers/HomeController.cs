using Microsoft.AspNetCore.Mvc;

namespace MasterLayoutApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
