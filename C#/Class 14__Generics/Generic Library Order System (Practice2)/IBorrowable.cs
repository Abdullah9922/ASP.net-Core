using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Library_Order_System__Practice2_
{
    public interface IBorrowable<TId>
    {
        public TId Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
