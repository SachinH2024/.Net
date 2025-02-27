using Microsoft.AspNetCore.Mvc;

namespace LoggingAuthCatchMiddilewareWithClassApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "<h1>Welcome to the Index action</h1>";
        }

        // Action method to handle requests to /Customer/Unauthorized
        public string Unauthorized()
        {
            return "<h1>You are not authorized</h1>";
        }
    }
}
