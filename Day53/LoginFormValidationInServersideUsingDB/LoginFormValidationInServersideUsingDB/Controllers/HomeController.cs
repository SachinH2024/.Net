using LoginFormValidationInServersideUsingDB.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LoginFormValidationInServersideUsingDB.Controllers
{
    public class HomeController : Controller
    {
        private AuthenticationService _authService = new AuthenticationService();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Username and password are required.";
                return View();
            }

            if (_authService.ValidateUser(username, password))
            {

                ViewBag.SuccessMessage = "Login successful!";
                return View();
            }

            ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
            return View();
        }
    }
}