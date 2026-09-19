
using Generic_Order_System__Practice2_;

Product<string> laptop = new Product<string>("LAP-101", "Laptop", 80000);
Product<string> mouse = new Product<string>("MOU-101", "Mouse", 1000);

Order<Product<string>, string> order = new Order<Product<string>, string>(5001);

order.AddItem(laptop, 2);
order.AddItem(mouse, 5);


order.PrintOrder();

Console.WriteLine();

order.RemoveItem("MOU-101");

Console.WriteLine("After removing mouse:");
order.PrintOrder();