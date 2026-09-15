
using Enum_Practice;

OrderStatus status = OrderStatus.Shipped;
Console.WriteLine($"Order Status: {status}");

if (status == OrderStatus.Shipped)
{
    Console.WriteLine("Your order is Shipped");
}

OrderStatus status2 = OrderStatus.Delivered;
if (status2 == OrderStatus.Delivered)
{
    Console.WriteLine("Your order is on the way!");
}
