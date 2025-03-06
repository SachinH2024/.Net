using AjaxCallEmailValidation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AjaxCallEmailValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegisterService _registerService;

        public HomeController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ValidateEmail(string email)
        {
            var isEmailExists = _registerService.IsEmailExists(email);
            return Json(isEmailExists ? "Email already exists" : "Email is available");
        }
    }
}