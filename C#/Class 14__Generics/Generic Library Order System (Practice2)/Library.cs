using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Library_Order_System__Practice2_
{
    public class Library <TBook, TId> where TBook : IBorrowable<TId>
    {
        private List<BorrowItem<TBook, TId>> borrowItems = new List<BorrowItem<TBook, TId>>();

        public void BorrowBook(TBook book, int day )
        {
            BorrowItem<TBook, TId> b = new BorrowItem<TBook, TId>();
            b.Book = book;
            b.Days = day;
            borrowItems.Add(b);
        }

        public void ReturnBook(TId id)
        {
            BorrowItem<TBook, TId>? temp = borrowItems.FirstOrDefault(x => x.Book.Id.Equals(id));
            if (temp != null)
            {
                borrowItems.Remove(temp);
            }
            else Console.WriteLine("No Book Found.");
        }

        public void PrintBorrowedBooks()
        {
            foreach(var item in borrowItems)
            {
                Console.WriteLine(item.Book.Id);
                Console.WriteLine(item.Book.Title);
                Console.WriteLine(item.Book.Author);
                Console.WriteLine(item.Days);
                item.FineCalculate();
            }
        }
    }
}
