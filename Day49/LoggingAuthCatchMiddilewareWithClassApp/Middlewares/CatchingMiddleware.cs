using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace LoggingAuthCatchMiddilewareWithClassApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CatchingMiddleware
    {
        private readonly RequestDelegate _next;

        public CatchingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);

            if (httpContext.Response.StatusCode == 401)
            {
                Console.WriteLine("[CATCH] Request failed with 401 Unauthorized.");
                return;
            }
            Console.WriteLine("[CATCH] Request passed with status code: " + httpContext.Response.StatusCode);
        }
    }

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class CatchingMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseCatchingMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<CatchingMiddleware>();
    //    }
    //}
}
