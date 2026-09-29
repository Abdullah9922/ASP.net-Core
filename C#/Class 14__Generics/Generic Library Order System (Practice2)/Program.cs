using Generic_Library_Order_System__Practice2_;
using System.Security.Cryptography;

Library<Book<string>, string> library = new Library<Book<string>, string>();

Book<string> book1 = new Book<string>("B-101", "Clean Code", "Robert C. Martin", 1500);
Book<string> book2 = new Book<string>("B-102", "Design Patterns", "Erich Gamma", 1800);
Book<string> book3 = new Book<string>("B-103", "The Pragmatic Programmer", "David Thomas", 1600);

BorrowItem<Book<string>, string> borrowItem = new BorrowItem<Book<string>, string>();
//borrowItem.Days = 5;
//borrowItem.Book = book1;

library.BorrowBook(book1, 5);
library.BorrowBook(book2, 10);
library.BorrowBook(book3, 20);

library.PrintBorrowedBooks();

library.ReturnBook("B-102");
library.PrintBorrowedBooks();