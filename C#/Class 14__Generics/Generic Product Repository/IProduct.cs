using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Product_Repository
{
    public interface IProduct<TId>
    {
        TId Id { get; }
        string Name { get; }
        decimal Price { get; }
    }
}
