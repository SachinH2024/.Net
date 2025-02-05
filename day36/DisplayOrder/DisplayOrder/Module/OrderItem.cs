using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayOrder.Module
{
    public class OrderItem
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderItem(string product, int quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }
    }
}
