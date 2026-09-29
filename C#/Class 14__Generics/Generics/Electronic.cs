using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics
{
    public class Electronic<T> : IProduct2<T>
        //where T : INumber<T>
    {
        public string Name { get; set; }

        public T Price { get; set; }
    }
}
