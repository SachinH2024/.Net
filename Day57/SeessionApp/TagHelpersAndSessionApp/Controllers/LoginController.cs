using Microsoft.AspNetCore.Mvc;
using TagHelpersAndSessionApp.DTOs;

namespace TagHelpersAndSessionApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(LoginDto loginDto)
        {
                return View();
        }
        //public IActionResult Index(LoginDto loginDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (loginDto.UserName == "admin" && loginDto.Password == "admin")
        //        {
        //            HttpContext.Session.SetString("username", loginDto.UserName);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ViewBag.Error = "Invalid Username or Password";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}
