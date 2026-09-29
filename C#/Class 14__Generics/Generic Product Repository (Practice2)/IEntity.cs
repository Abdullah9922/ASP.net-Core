using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Product_Repository__Practice2_
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
