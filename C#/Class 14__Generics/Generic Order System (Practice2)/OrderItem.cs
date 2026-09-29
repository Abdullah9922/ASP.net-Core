using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Order_System__Practice2_
{
    public class OrderItem<TProduct, TId>
    where TProduct : IProduct<TId>
    {
        public TProduct Product { get; set; } // kon type ar product seta bola disse. 
        public int Quantity { get; set; }

        public OrderItem(TProduct product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return Product.Price * Quantity;
        }

        public void Print()
        {
            Console.WriteLine($"Product : {Product.Name}"); // 10 number line ar jonne amra ae vabe likte parsi
            Console.WriteLine($"Price   : {Product.Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total   : {GetTotal()}");
        }
    }
}
