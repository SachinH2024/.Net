using Microsoft.AspNetCore.Mvc;

namespace MasterLayoutApp.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Check()
            { return View(); }
    }
}
