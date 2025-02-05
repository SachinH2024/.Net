using DisplayOrder.Module;

namespace DisplayOrder
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            // Customer Example
            List<Customer> customers = new List<Customer>()
                {
                new Customer("Alice", "New York"),
                new Customer("Bob", "Los Angeles"),
                new Customer("Charlie", "New York")
                };

            Dictionary<string, List<Customer>> groupedCustomers = GroupCustomersByCity(customers);

            foreach (var cityGroup in groupedCustomers)
            {
                Console.WriteLine($"\nCustomers in {cityGroup.Key}:");
                foreach (var customer in cityGroup.Value)
                {
                    Console.WriteLine($"- {customer.Name}");
                }
            }


            // Order Example
            Order order1 = new Order();
            OrderItem item1 = new OrderItem("Laptop", 1, 1200);
            order1.AddOrderItem(item1);
            order1.AddOrderItem(item1); // Adding the same item twice
            order1.PrintDetails();

            Console.ReadKey();
        }

        public static Dictionary<string, List<Customer>> GroupCustomersByCity(List<Customer> customers)
        {
            return customers.GroupBy(c => c.City)
                            .ToDictionary(g => g.Key, g => g.ToList());
        }
    }


}
