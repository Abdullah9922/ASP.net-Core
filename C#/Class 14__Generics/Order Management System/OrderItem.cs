using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Management_System
{
    public class OrderItem<TProductId> : IOrderItem<TProductId>
    {
        public TProductId ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }
        public OrderItem(TProductId Pid, string name, decimal price, int quantity)
        {
            ProductId = Pid;
            ProductName = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
