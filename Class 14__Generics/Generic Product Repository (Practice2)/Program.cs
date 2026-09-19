

using Generic_Product_Repository__Practice2_;

Employee e1 = new Employee("EMP-101", "Asif", "CSE", 50000);
Employee e2 = new Employee("EMP-102", "Rahim", "IT", 45000);
Employee e3 = new Employee("EMP-103", "Karim", "HR", 40000);

Repository<Employee, string> repo = new();
// Add
repo.Add(e1);
repo.Add(e2);
repo.Add(e3);

// GetById
Employee? employee = repo.GetById("EMP-102");

Console.WriteLine(employee?.Name);
Console.WriteLine(employee?.Department);
Console.WriteLine(employee?.Salary);

// GetAll
List<Employee> employees = repo.GetAll();

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Id} - {e.Name} - {e.Department} - {e.Salary}");
}

// Remove
repo.Remove(e2);


Product p1 = new Product
{
    Id = 101,
    Name = "Laptop",
    Price = 85000
};

Product p2 = new Product
{
    Id = 102,
    Name = "Mouse",
    Price = 1200
};

Product p3 = new Product
{
    Id = 103,
    Name = "Keyboard",
    Price = 2500
};

Product p4 = new Product
{
    Id = 104,
    Name = "Monitor",
    Price = 22000
};

Product p5 = new Product
{
    Id = 105,
    Name = "Headphone",
    Price = 3500
};

Repository<Product, int> repo2 = new();

repo2.Add(p1);
repo2.Add(p2);
repo2.Add(p3);
repo2.Add(p4);
repo2.Add(p5);

Product? product = repo2.GetById(103);

Console.WriteLine(product?.Name);
Console.WriteLine(product?.Price);


