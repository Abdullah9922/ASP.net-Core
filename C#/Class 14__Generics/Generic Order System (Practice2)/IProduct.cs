using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Order_System__Practice2_
{
    public interface IProduct<TId>
    {
        TId Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
