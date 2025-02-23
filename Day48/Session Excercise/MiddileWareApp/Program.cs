namespace MiddileWareApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var WebAppBuilder = WebApplication.CreateBuilder(args);
            var WebApp = WebAppBuilder.Build();

            WebApp.Use(async (context, next) =>
            {
                Console.WriteLine("Inside Common headers Logging  middleware");
                Console.WriteLine(context.Request.Path);
                Console.WriteLine(context.Request.Method);

                foreach (var item in context.Request.Headers)
                    Console.WriteLine(item.Key + " " + item.Value);
                await next();
            });
            ////webApp.UseMyRddMiddleWare();
            WebApp.Use(async (context, next) =>
            {
                //prepoossing

                Console.WriteLine("Middleware 1(pre)");
                await next();
                Console.WriteLine("Middleware 1(post)");
                //post postpressing
            });

            WebApp.Use(async (context, next) =>
            {
                //prepoossing
                Console.WriteLine("Middleware 2(pre)");
                await next();
                Console.WriteLine("Middleware 2(post)");
                //post postpressing
            });

            WebApp.Map("/howdy", (appbuilder) =>
            {
                appbuilder.Run(async (context) =>
                {
                await context.Response.WriteAsync("<h1>Welcome to Howdy!!</h1>");
                });

            });

            WebApp.MapGet("/", () => "Hello World!");

            WebApp.Run();
        }
    }
}
