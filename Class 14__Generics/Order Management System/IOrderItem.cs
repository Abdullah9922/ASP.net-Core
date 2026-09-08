using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Management_System
{
    public interface IOrderItem<TProductId>
    {
        TProductId ProductId { get; set; }
        string ProductName { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
    }
}
