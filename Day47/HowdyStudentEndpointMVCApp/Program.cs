namespace HowdyStudentEndpointMVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webAppBuilder = WebApplication.CreateBuilder(args);

            var webApp = webAppBuilder.Build(); 

            
            webApp.MapGet("/", () =>
            {
                Console.WriteLine("HTTP request came ");
                return new { CompanyName = "RRD", Location = "Chennai" };
            });

            
            webApp.MapGet("/howdy", () =>
            {
                return "Hello, welcome to my application!";
            });

           
            webApp.MapGet("/students", () =>
            {
                var students = new[]
                {
                new { Id = 1, Name = "Maya", Age = 20 },
                new { Id = 2, Name = "Sachin", Age = 22 },
                new { Id = 3, Name = "Minu", Age = 21 }
            };
                return students;
            });

            webApp.Run(); 
        }
    }
}

