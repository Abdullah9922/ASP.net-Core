using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Book : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
