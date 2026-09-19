using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
