using Microsoft.AspNetCore.Mvc;

namespace RedirectController.Controllers
{
    public class AnotherController : Controller
    {
        public IActionResult Index()
        {
            // Logic for the AnotherController's Index action
            return View(); // Or any other view
        }

        public IActionResult AnotherAction()
        {
            return View();
        }
    }
}
