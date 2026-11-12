using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Contracts
{
    public interface IAggregateRoot<TKey>
    {
        public TKey Id { get; set; }
    }
}
