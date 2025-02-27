using CustomerDetailsApp.Model;
using Microsoft.AspNetCore.Mvc;


namespace CustomerDetailsApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "John Doe",
                Addresses = new List<Address>
                {
                    new Address { Street = "123 Main St", City = "Anytown", ZipCode = "12345" },
                    new Address { Street = "456 Oak Ave", City = "Anytown", ZipCode = "12345" }
                }
            },
            new Customer
            {
                Id = 2,
                Name = "Jane Smith",
                Addresses = new List<Address>
                {
                    new Address { Street = "789 Pine Ln", City = "Sometown", ZipCode = "67890" }
                }
            }
        };

            return View(customers);
        }
    }
}
