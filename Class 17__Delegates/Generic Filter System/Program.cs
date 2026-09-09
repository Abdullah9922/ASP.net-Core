using Generic_Filter_System;

MyCollection<Product> products = new MyCollection<Product>();

products.Add(new Product("Laptop", 80000, 5));
products.Add(new Product("Mouse", 1500, 20));
products.Add(new Product("Keyboard", 3000, 0));
products.Add(new Product("Monitor", 25000, 8));
products.Add(new Product("Headphone", 5000, 15));


// Price >= 10000
List<Product> expensiveProducts =
    products.Filter(p => p.Price >= 10000);

Console.WriteLine("Expensive Products:");

foreach (Product p in expensiveProducts)
{
    Console.WriteLine(p);
}


// Stock > 0
List<Product> availableProducts =
    products.Filter(p => p.Stock > 0);

Console.WriteLine("\nAvailable Products:");

foreach (Product p in availableProducts)
{
    Console.WriteLine(p);
}


// Price <= 5000
List<Product> cheapProducts =
    products.Filter(p => p.Price <= 5000);

Console.WriteLine("\nCheap Products:");

foreach (Product p in cheapProducts)
{
    Console.WriteLine(p);
}
    