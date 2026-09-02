using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IProduct2<T>
       
    {
        string Name { get; }
        T Price { get; }
    }
}
