using Mini_Shopping_System__Practice_;
//delegate void PrintProduct(Product product);

List<Product> productList = new List<Product>()
{
    new Product { Name = "Laptop", Price =80000, Category = "Electronics" },
    new Product { Name = "Mouse", Price = 1500, Category = "Electronics" },
    new Product { Name = "Keyboard", Price = 3000, Category = "Electronics" },
    new Product { Name = "Shirt", Price = 1200, Category = "Clothing" },
    new Product { Name = "Pant", Price = 2000, Category = "Clothing" },
    new Product { Name = "Phone", Price = 50000, Category = "Electronics" }
};


Predicate<Product> FilterPrice = x => x.Price > 2000 || x.Category == "Electronics";
Func<Product, double> Discount = x => x.Price * 0.1;
Action<Product> Print = x => Console.WriteLine($"{x.Name} | {x.Category} | {x.Price}");


foreach (Product product in productList)
{
    if (FilterPrice(product))
    {
        double result = Discount(product);
        product.Price = result;
        Print(product);
    }
}

