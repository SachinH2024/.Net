using LoginValidationAttributesApp.DTOs;

using Microsoft.AspNetCore.Mvc;

namespace LoginValidationAttributesApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //ViewBag.LoggedInUser = dto.UserName;  //This is getting the data using viewBag but we can't pass to other controller it will loss
            TempData["LoggedInUser"] = dto.UserName;
            return RedirectToAction("Index", "welcome");
        }

        public IActionResult BootstrapForm()
        {
            return View();
        }
    }
}