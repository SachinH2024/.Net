using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace LoggingAuthCatchMiddilewareWithClassApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            if (httpContext.Request.Path.ToString().Contains("/unauthorized"))
            {
                Console.WriteLine("[AUTH] Unauthorized URL - Request is short-circuited.");
                httpContext.Response.StatusCode = 401; 
                return;
            }

            Console.WriteLine("[AUTH] Authorization passed for: " + httpContext.Request.Path);
            await _next(httpContext); 
        }
    }
    

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class AuthenticationMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<AuthenticationMiddleware>();
    //    }
    //}
}
