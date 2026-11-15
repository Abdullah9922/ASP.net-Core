using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Course : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Cost { get; set; }
    }
}
