using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IRepository<TAggregateRoot, TKey> 
        where TAggregateRoot : class, IAggregateRoot<TKey>
        where TKey: IComparable<TKey>
    {
        void Add(TAggregateRoot aggregateRoot);
        void Remove(TAggregateRoot aggregateRoot);
        void Update(TAggregateRoot aggregateRoot);
    }
}
