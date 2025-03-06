using Microsoft.AspNetCore.Mvc;

namespace MasterLayoutApp.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
