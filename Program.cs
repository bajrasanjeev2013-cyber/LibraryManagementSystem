using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Member sanjeev = new Member("M001", "Sanjeev Bajracharya", "sanjeev.bajracharya@example.com");
            Member ben = new Member("M002", "Ben Carter", "ben.carter@example.com");
            library.AddMember(sanjeev);
            library.AddMember(ben);

            Book book1 = new Book("B001", "Introduction to Algorithms", "Thomas H. Cormen", "9780262046305");
            Book book2 = new Book("B002", "The C Programming Language", "Brian W. Kernighan", "9780131103627");
            Book book3 = new Book("B003", "Effective Java", "Joshua Bloch", "9780134685991");
            Book book4 = new Book("B004", "Head First Design Patterns", "Eric Freeman", "9781492078005");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("=== Initial Catalogue ===");
            library.DisplayAllBooks();
            library.DisplayAllMembers();

            Console.WriteLine("\n=== Issuing Loans ===");
            library.IssueLoan(sanjeev, book1);
            library.IssueLoan(sanjeev, book2);
            library.IssueLoan(sanjeev, book3);
            library.IssueLoan(sanjeev, book4);

            library.IssueLoan(ben, book4);

            Console.WriteLine("\n=== Status After Loans ===");
            library.DisplayAllBooks();
            library.DisplayAllMembers();

            library.DisplayAllLoans();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
