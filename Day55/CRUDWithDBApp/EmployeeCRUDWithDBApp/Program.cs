using EmployeeCRUDApp.Services;
using EmployeeCRUDWithDBApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEmployeeService, EmployeeSqlClientService>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=DisplayAll}/{id?}");
//app.MapGet("/", () => "Hello World!");

app.Run();
