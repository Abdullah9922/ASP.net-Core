using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Order_Management_System

{
    public class Order<TId, TProductId, Titem>  : IEntity<TId>
        where TId : INumber<TId>
        where TProductId : class , IOrderItem<TProductId>, new()
        where Titem : INumber<Titem>
    {
        public TId Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Items {  get; set; }

        private readonly List<TProductId> list ;
        public Order()
        {
            list = new List<TProductId>();
        }

        public void AddItem(TProductId product)
        {
            list.Add(product);
        }

        public void RemoveItem(TProductId productId)
        {
            TProductId found = list.Find(x => x.ProductId == productId);

            if (found != null)
            {
                list.Remove(found);
                Console.WriteLine("Removed successfully");
            }
            else Console.WriteLine("Product Not found.");
        }

        public List<TProductId> GetAll()
        {
            return list.ToList();
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach(TProductId product in list)
            {
                 total += product.Quantity * product.Price;
            }
            return total;
        }

        public TProductId GetMostExpensiveItem()
        {
            return list.OrderByDescending(x => x.Price).First();
        }
    }
}
