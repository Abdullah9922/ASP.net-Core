using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Library_Order_System__Practice2_
{
    public class Book<TId> : IBorrowable<TId>
    {
        public TId? Id { get ; set; }
        public string? Title { get ; set; }
        public string? Author { get ; set ; }
        public double ? Price { get ; set ; }

        public Book(TId id, string title, string author, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
