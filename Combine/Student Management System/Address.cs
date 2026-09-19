using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    public struct Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }

        public Address(string city, string country, int postalCode)
        {
            City = city;
            Country = country;
            PostalCode = postalCode;
        }

        public void PrintAddress(Address address)
        {
            Console.WriteLine($"Address    : {address.City}, {address.Country}, {address.PostalCode}");
        }
    }
}
