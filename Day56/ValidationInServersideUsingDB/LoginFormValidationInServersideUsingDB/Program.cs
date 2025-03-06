using LoginFormValidationInServersideUsingDB.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IService, AuthenticationService>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");
//app.MapGet("/", () => "Hello World!");

app.Run();
