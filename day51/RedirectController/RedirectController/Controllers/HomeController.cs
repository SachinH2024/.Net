using Microsoft.AspNetCore.Mvc;

namespace RedirectController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Logic for the home page (if any)
            return View(); // Or any other view
        }

        public IActionResult RedirectAction()
        {
            // Redirect to the Index action of the AnotherController
            return RedirectToAction("Index", "Another");
        }
    }
}
