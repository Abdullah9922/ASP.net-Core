using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Supplier : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
