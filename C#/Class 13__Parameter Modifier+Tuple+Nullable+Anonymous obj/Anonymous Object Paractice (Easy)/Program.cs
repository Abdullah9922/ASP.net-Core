

var student = new { Id = 102, Name = "Asif", Department = "CSE", CGPA = 3.56 };
Console.WriteLine("Name: " +  student.Name);

var products = new[]
{
    new { Id = 101, Name= "Laptop", Price= 80000},
    new {Id= 102, Name= "Mouse", Price= 1000}
};

foreach (var product in products)
{
    Console.WriteLine(product.Name + " " + product.Price);
}

foreach (var product in products)
{
    if(product.Price > 1000) Console.WriteLine(product.Name + " " + product.Price);
}
