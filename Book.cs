using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        private string bookId;
        private string title;
        private string author;
        private string isbn;
        private bool isAvailable;

        public Book(string bookId, string title, string author, string isbn)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.isAvailable = true;
        }

        public string BookId
        {
            get { return bookId; }
            private set { bookId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book ID: {bookId} | Title: {title} | Author: {author} | " +
                               $"ISBN: {isbn} | Available: {(isAvailable ? "Yes" : "No")}");
        }
    }
}
