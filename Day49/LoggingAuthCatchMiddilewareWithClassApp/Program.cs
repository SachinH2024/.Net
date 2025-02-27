using LoggingAuthCatchMiddilewareWithClassApp.Middlewares;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();
app.UseMiddleware<CatchingMiddleware>();

app.MapDefaultControllerRoute();

app.Run();

