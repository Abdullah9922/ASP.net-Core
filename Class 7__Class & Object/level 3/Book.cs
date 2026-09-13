using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace level_3
{
    public class Book
    {

        private readonly int _id;
        private string _title { get; set; }
        private string _author { get; set; }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { if (value > 0) _price = value; }
        }
         
        
        public Book() : this(0)
        {

        }

        public Book(int id) : this(id,"Unknown")
        {

        }

        public Book(int id,string title) : this(id,title,"Unknown")
        {

        }

        public Book(int id, string title, string author) : this(id, title, author, 0.00)
        {

        }

        public Book(int id, string title, string author, double price)
        {
            _id = id;
            _title = title;
            _author = author;
            _price = price;
        }


        public void Display()
        {
            Console.WriteLine("Id: " + _id);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("Price: " + _price);
        }

    }
}
