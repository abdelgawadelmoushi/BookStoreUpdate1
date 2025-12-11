
using System;
using System.Collections.Generic;

namespace LibraryTest
{
    class Book
    {
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
        public string Author { get; set; }

        public Book(string title, int isbn, int pages, bool isAvailable, string author)
        {
            Title = title;
            ISBN = isbn;
            Pages = pages;
            IsAvailable = isAvailable;
            Author = author;
        }
    }

    class Borrower
    {
        public string Name { get; set; }
        public string BorrowedBook { get; set; }
        public bool IsBorrowed { get; set; }

        public Borrower(string name, string borrowedBook)
        {
            Name = name;
            BorrowedBook = borrowedBook;
            IsBorrowed = true;
        }
    }

    class BorrowerList
    {
        private List<Borrower> borrowers = new List<Borrower>();

        public void AddBorrower(Borrower borrower)
        {
            borrowers.Add(borrower);
        }

        public void DisplayBorrowers()
        {
            Console.WriteLine("List of Borrowers:");
            for (int i = 0; i < borrowers.Count; i++)
            {
                Console.WriteLine($"Name:  {borrowers[i].Name}  Borrowed Book:  {borrowers[i].BorrowedBook}");
            }
        }

        public bool IsBookBorrowed(string bookTitle)
        {
            for (int i = 0; i < borrowers.Count; i++)
            {
                if (borrowers[i].BorrowedBook.ToLower() == bookTitle.ToLower())
                    return true;
            }
            return false;
        }

        public List<Borrower> GetBorrowers()
        {
            return borrowers;
        }

        public void RemoveBorrower(Borrower borrower)
        {
            borrowers.Remove(borrower);
        }
    }

    class ReturnedBookList
    {
        private List<string> returners = new List<string>();

        public void AddReturnedBook(string bookTitle)
        {
            returners.Add(bookTitle);
        }

        public void DisplayReturnedBooks()
        {
            Console.WriteLine("Returned Books:");
            for (int i = 0; i < returners.Count; i++)
            {
                Console.WriteLine("Returned Book: " + returners[i]);
            }
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();
        private BorrowerList borrowerList = new BorrowerList();
        private ReturnedBookList returnedBookList = new ReturnedBookList();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("List of Books:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Title:  {books[i].Title}  Author: {books[i].Author}   Available: {books[i].IsAvailable}");
            }
        }

        public void DisplayBorrowers()
        {
            borrowerList.DisplayBorrowers();
        }

        public void DisplayReturnedBooks()
        {
            returnedBookList.DisplayReturnedBooks();
        }

        public bool IsBookAvailable(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower() == title.ToLower())
                    return books[i].IsAvailable;
            }
            return false;
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            int count = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].IsAvailable)
                {
                    Console.WriteLine($"Title:  {books[i].Title} Author:  {books[i].Author}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No books are currently available.");
            }
        }

        public void BorrowBook(string borrowerName, string bookTitle)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower().Contains(bookTitle.ToLower()))
                {
                    if (books[i].IsAvailable)
                    {
                        books[i].IsAvailable = false;
                        borrowerList.AddBorrower(new Borrower(borrowerName, bookTitle));
                        Console.WriteLine($"{borrowerName} borrowed {bookTitle} successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"The book {bookTitle} is currently not available.");
                    }
                    return;
                }
            }
            Console.WriteLine("The book \"" + bookTitle + "\" does not exist in the library.");
        }

        public void ReturnBook(string bookTitle)
        {
            List<Borrower> borrowers = borrowerList.GetBorrowers();
            for (int i = 0; i < borrowers.Count; i++)
            {
                if (borrowers[i].BorrowedBook.ToLower().Contains(bookTitle.ToLower()))
                {
                    Borrower borrower = borrowers[i];
                    returnedBookList.AddReturnedBook(bookTitle);
                    borrowerList.RemoveBorrower(borrower);

                    for (int j = 0; j < books.Count; j++)
                    {
                        if (books[j].Title.ToLower().Contains(bookTitle.ToLower()))
                        {
                            books[j].IsAvailable = true;
                            break;
                        }

                    }
                    Console.WriteLine("Book \"" + bookTitle + "\" has been returned.");

                    return;
                }
            }
            Console.WriteLine("No borrower found with the book \"" + bookTitle + "\".");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();

            myLibrary.AddBook(new Book("Mr.Strange", 1, 200, true, "Amr Arafa"));
            myLibrary.AddBook(new Book("Skape Plan", 2, 150, true, "Ahmed"));
            myLibrary.AddBook(new Book("Lord of the Rings", 3, 200, true, "Khaled"));

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Display borrowers");
                Console.WriteLine("5. Display returned books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter option number: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    myLibrary.DisplayBooks();
                else if (choice == "2")
                {
                    myLibrary.DisplayAvailableBooks();
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the book title to borrow: ");
                    string book = Console.ReadLine();
                    myLibrary.BorrowBook(name, book);
                }
                else if (choice == "3")
                {
                    Console.Write("Enter the book title to return: ");
                    string book = Console.ReadLine();
                    myLibrary.ReturnBook(book);
                }
                else if (choice == "4")
                    myLibrary.DisplayBorrowers();
                else if (choice == "5")
                    myLibrary.DisplayReturnedBooks();
                else if (choice == "6")
                    break;
                else
                    Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}
