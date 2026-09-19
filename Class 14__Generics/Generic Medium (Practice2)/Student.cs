using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
