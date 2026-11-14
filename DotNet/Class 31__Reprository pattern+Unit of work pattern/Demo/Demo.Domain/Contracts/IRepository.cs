using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Contracts
{
    public interface IRepository <TAggregateRoot, Tkey> 
        where TAggregateRoot : class, IAggregateRoot<Tkey>
        where Tkey : IComparable<Tkey>
    {
        
        void Add(TAggregateRoot aggregateRoot);
        void Remove(TAggregateRoot aggregateRoot);
        void Update(TAggregateRoot aggregateRoot);

    }
}
