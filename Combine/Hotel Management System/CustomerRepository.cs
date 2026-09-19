using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class CustomerRepository
    {
        private readonly List<Customer> _customers = new();

        public void AddCustomer(Customer customer)
        {
            bool found = _customers.Any(x => x.Id == customer.Id);
            if (customer != null && !found)
            {
                _customers.Add(customer);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid! Try Again");
                Console.WriteLine();
            }
        }

        public void RemoveCustomer(int id)
        {
            Customer? customer = _customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Customer not Found.");
                Console.WriteLine();
            }
        }

        public Customer? GetById(int id)
        {
            Customer? customer = _customers.FirstOrDefault(x =>x.Id == id);
            if (customer != null) return customer;
            else return null;
        }

        public void ShowCustomerDetails(int id)
        {
            Customer? c = _customers.FirstOrDefault(x => x.Id == id);
            if (c != null)
            {
                Customer.PrintInfo(c);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Customer not Found.");
                Console.WriteLine();
            }
        }

        internal void AddCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
