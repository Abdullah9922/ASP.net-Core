using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Order_System__Practice2_
{
    public class Order<TProduct, TId>
    where TProduct : IProduct<TId>
    {
        public int OrderId { get; set; }

        private List<OrderItem<TProduct, TId>> _items = new();

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public void AddItem(TProduct product, int quantity)
        {
            OrderItem<TProduct, TId> item = new OrderItem<TProduct, TId>(product, quantity);

            _items.Add(item);
        }

        public void RemoveItem(TId productId)
        {
            var item = _items.FirstOrDefault(x => EqualityComparer<TId>.Default.Equals(x.Product.Id, productId));

            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach (var item in _items)
            {
                total += item.GetTotal();
            }

            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine("----------------------");

            foreach (var item in _items)
            {
                item.Print();
                Console.WriteLine("----------------------");
            }

            Console.WriteLine($"Grand Total: {CalculateTotal()}");
        }
    }
}
