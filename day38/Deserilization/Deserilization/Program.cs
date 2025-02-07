using System;
using System.Text.Json;

namespace Deserilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\.Net\.Net\day38\cust1.json");
            var jsonString = sr.ReadToEnd();

            Console.WriteLine(jsonString);

            var customer = JsonSerializer.Deserialize<Customer>(jsonString);

            Console.WriteLine("Dserialized customer Details :");
            Console.WriteLine("Customer ID:" + customer.Id);
            Console.WriteLine("Customer Name:" + customer.Name);
            Console.WriteLine();
            Console.WriteLine("Customer Address");
            foreach (Address address in customer.Addresses)
            {
                Console.WriteLine($"- City: {address.City}, Country: {address.Country}");
            }

        }
    }
}
