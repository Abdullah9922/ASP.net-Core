using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Order_Management_System
{
    public class OrderRepository<TOrderId, TProductId, TItem, TOrder> 
        where TOrder : class, IEntity<TOrderId>, new()
        where TOrderId : INumber<TOrderId>
        where TProductId : class, IOrderItem<TProductId>, new()
        where TItem : INumber<TItem>
    {
        private readonly Dictionary<TOrderId, TOrder> _orders = new();

        public void AddOrder(TOrder order)
        {
            _orders.Add(order.Id, order);
        }

        public void RemoveOrder(TOrderId orderId)
        {
            _orders.Remove(orderId);
        }

        public  List<TOrder> GetAll()
        {
            return _orders.Values.ToList();
        }

        public decimal GetTotalRevenue(Func<TOrder, decimal> getTotal)
        {
            decimal total = 0;

            foreach (TOrder order in _orders.Values)
            {
                total += getTotal(order);
            }

            return total;
        }
    }
}
