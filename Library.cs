using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;
        private List<Loan> loans;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            loans = new List<Loan>();
        }

        public void AddBook(Book book) => books.Add(book);

        public void AddMember(Member member) => members.Add(member);

        public bool IssueLoan(Member member, Book book)
        {
            if (!book.IsAvailable)
            {
                Console.WriteLine($"Cannot issue loan: \"{book.Title}\" is not available.");
                return false;
            }

            if (!member.CanBorrow())
            {
                Console.WriteLine($"Cannot issue loan: {member.Name} has reached the " +
                                   $"borrowing limit of {Member.MaxBorrowLimit} books.");
                return false;
            }

            Loan newLoan = new Loan(member, book, DateTime.Now);
            loans.Add(newLoan);

            book.IsAvailable = false;
            member.AddLoan(book);

            Console.WriteLine($"Loan issued: \"{book.Title}\" to {member.Name}.");
            return true;
        }

        public void DisplayAllLoans()
        {
            Console.WriteLine("\n--- All Loan Records ---");
            if (loans.Count == 0)
            {
                Console.WriteLine("No loans have been issued.");
                return;
            }

            foreach (Loan loan in loans)
            {
                loan.DisplayLoanDetails();
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("\n--- All Books ---");
            foreach (Book book in books)
            {
                book.DisplayBookInfo();
            }
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("\n--- All Members ---");
            foreach (Member member in members)
            {
                member.DisplayMemberInfo();
            }
        }
    }
}
