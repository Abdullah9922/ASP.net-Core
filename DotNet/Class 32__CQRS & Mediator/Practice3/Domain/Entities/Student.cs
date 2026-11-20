using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Student : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
