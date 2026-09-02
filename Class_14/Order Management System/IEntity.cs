using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Management_System
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
