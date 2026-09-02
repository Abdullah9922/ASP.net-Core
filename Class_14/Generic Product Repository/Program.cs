using Generic_Product_Repository;


ProductRepository<Product, int> repository =new ProductRepository<Product, int>();

repository.Add(new Product(1, "Laptop", 80000));
repository.Add(new Product(2, "Mouse", 1500));
repository.Add(new Product(3, "Keyboard", 5000));
repository.Add(new Product(4, "Monitor", 25000));

Product? product = repository.GetById(2);

if (product != null)
{
    Console.WriteLine("Product Found:");
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
}

// Remove
repository.Remove(3);
Console.WriteLine("Product Removed:}");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("All Products:");
List<Product> allProducts = repository.GetAll();
foreach (Product p in allProducts)
{
    Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
}


// Most Expensive
Product? expensive = repository.GetMostExpensive();

if (expensive != null)
{
    Console.WriteLine("Most Expensive Product:");

    Console.WriteLine($"{expensive.Name} - {expensive.Price}");
}

//ProductRepository<AnotherProduct, long>