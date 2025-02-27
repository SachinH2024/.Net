using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace LoggingAuthCatchMiddilewareWithClassApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            Console.WriteLine($"[LOG] Time: {DateTime.Now}, Resource: {httpContext.Request.Path}");
            await _next(httpContext);
        }
    }

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class LoggingMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<LoggingMiddleware>();
    //    }
    //}
}
