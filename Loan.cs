using System;

namespace LibraryManagementSystem
{
    public class Loan
    {
        private Member member;
        private Book book;
        private DateTime loanDate;
        public Loan(Member member, Book book, DateTime loanDate)
        {
            this.member = member;
            this.book = book;
            this.loanDate = loanDate;
        }

        public Member Member
        {
            get { return member; }
            private set { member = value; }
        }

        public Book Book
        {
            get { return book; }
            private set { book = value; }
        }

        public DateTime LoanDate
        {
            get { return loanDate; }
            private set { loanDate = value; }
        }

        public void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan -> Member: {member.Name} ({member.MemberId}) | " +
                               $"Book: \"{book.Title}\" ({book.BookId}) | " +
                               $"Loan Date: {loanDate:yyyy-MM-dd}");
        }
    }
}
