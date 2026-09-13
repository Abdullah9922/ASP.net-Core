using System;

class User
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Name = "Asif",
            Role = "Admin",
            Age = 25
        };

        if (user is { Role: "Admin", Age: >= 18 and <= 60 })
        {
            Console.WriteLine("Access Granted");
            Console.WriteLine($"Welcome {user.Name}");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}