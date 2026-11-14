using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Category : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
