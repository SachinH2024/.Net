using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;


namespace RegistrationApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Registration model)
        {
            if (ModelState.IsValid)
            {
                // Process registration (e.g., save to database)
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
