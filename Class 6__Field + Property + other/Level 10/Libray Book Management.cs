using System;
using System.Collections.Generic;
using System.Text;

namespace Level_10
{
    public class Libray_Book_Management
    {
        private int _bookId { get; set; }
        private string _title { get; set; }
        private string _author { get; set; }
        private int _price;
        private int _quantity;

        public int Price{
            get { return _price; }
            set { if (value > 0) _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { if (_quantity > 0)  _quantity = value; }
        }

        public Libray_Book_Management() : this(0,"unknown", "unknown")
        {
        }

        public Libray_Book_Management(int bookId, string title, string author) : this(bookId, title, author, 0,1)
        {
        }

        public Libray_Book_Management(int bookId, string title, string author, int price, int quantity)
        {
            _bookId = bookId;
            _title = title;
            _author = author;
            _price = price;
            _quantity = quantity;
        }

        public void SellBook(int qty)
        {
            if(_quantity> 0) _quantity -= qty;
            else Console.WriteLine("Book not available");
        }

        public void Restock(int qty)
        {
            if (qty > 0) _quantity += qty;
        }

        public void Display()
        {
            Console.WriteLine("Book's ID    : " + _bookId);
            Console.WriteLine("Book's Title : " + _title);
            Console.WriteLine("Book's Author: " + _author);
            Console.WriteLine("Book's Price : " + _price);
            Console.WriteLine("Quantity     : " + _quantity);
            Console.WriteLine();
        }

    }
}
