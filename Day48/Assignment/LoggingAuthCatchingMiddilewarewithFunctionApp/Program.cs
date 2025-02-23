
var builder = WebApplication.CreateBuilder(args);
var webApp = builder.Build();


webApp.Use(async (context, next) =>
{
    Console.WriteLine($"[LOG] Time: {DateTime.Now}, Resource: {context.Request.Path}");
    await next();
});



webApp.Use(async (context, next) =>
{
        if (context.Request.Path.ToString().Contains("/unauthorized"))
    {
        Console.WriteLine("[AUTH] Unauthorized URL - Request is short-circuited.");
        context.Response.StatusCode = 401; 
        return; 
    }

    Console.WriteLine("[AUTH] Authorization passed for: " + context.Request.Path);
    await next();
});


webApp.Use(async (context, next) =>
{
    await next(); 

    if (context.Response.StatusCode == 401)
    {
        Console.WriteLine("[CATCH] Unauthorized access - missing or invalid credentials.");
    }
    else
    {
        Console.WriteLine($"[CATCH] Request passed with status code: {context.Response.StatusCode}");
    }
});

webApp.MapGet("/Index", () =>
{
    return "<h1>Welcome to the Index action</h1>";
});

webApp.MapGet("/Unauthorized", () =>
{
    return "<h1>You are not authorized</h1>";
});

webApp.MapGet("/", () => "Hello World!");

webApp.Run();




