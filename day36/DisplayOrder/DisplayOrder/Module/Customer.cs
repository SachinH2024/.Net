using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayOrder.Module
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(string name, string city)
        {
            Name = name;
            City = city;
        }
    }
}
