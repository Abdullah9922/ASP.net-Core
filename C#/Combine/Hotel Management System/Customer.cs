using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class Customer
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public long PhoneNumber { get; private set; }
        public string? Email { get; private set; }
        public CustomerType CustomerType { get; private set; }

        public Customer(int id, string name, long phoneNumber, string? email, CustomerType type)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            CustomerType = type;
        }

        public static void PrintInfo(Customer c)
        {
            Console.WriteLine();
            Console.WriteLine($"ID            : {c.Id}");
            Console.WriteLine($"Name          : {c.Name}");
            Console.WriteLine($"Phone Number  : {c.PhoneNumber}");
            Console.WriteLine($"Email         : {c.Email}");
            Console.WriteLine($"Customer Type : {c.CustomerType}");
            Console.WriteLine();
        }
    }
}
