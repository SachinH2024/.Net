using LoginFormValidationInServersideUsingDB.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LoginFormValidationInServersideUsingDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ValidateEmail(string username)
        {
            var isUserAvailable = _service.IsUserAvailable(username);
            return Json(isUserAvailable ? "User already exists" : "User is available");
        }
        
        //[HttpGet]
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Login(string username, string password)
        //{
        //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        //    {
        //        ViewBag.ErrorMessage = "Username and password are required.";
        //        return View();
        //    }

        //    if (_authService.ValidateUser(username, password))
        //    {

        //        ViewBag.SuccessMessage = "Login successful!";
        //        return View();
        //    }

        //    ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
        //    return View();
        //}
    }
}