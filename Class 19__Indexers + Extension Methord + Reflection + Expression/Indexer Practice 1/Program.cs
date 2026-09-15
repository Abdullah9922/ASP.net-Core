
using Indexer_Practice_1;

Product[] products =
{
     new Product(101, "Laptop", 80000),
     new Product(102, "Mouse", 1000),
     new Product(103, "Keyboard", 2000)
};

Inventory inventory = new Inventory(products);


Console.WriteLine(inventory[0].ProductName);
Console.WriteLine(inventory[1].ProductName);

Console.WriteLine(inventory[0].Price);