using Microsoft.AspNetCore.Mvc;

namespace TagHelpersAndSessionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse()
        {
            return View();
        }


    }
}
