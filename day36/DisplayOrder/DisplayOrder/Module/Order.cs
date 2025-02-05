using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayOrder.Module
{
    public class Order
    {
        private List<OrderItem> _orderItems;

        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public void PrintDetails()
        {
            Console.WriteLine("Order Details:");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"Product: {item.Product}, Quantity: {item.Quantity}, Price: {item.Price}");
            }
        }
    }
}
