using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Member
    {
        private string memberId;
        private string name;
       

        private List<Book> currentLoans;

        public const int MaxBorrowLimit = 3;

        public Member(string memberId, string name, string email)
        {
            this.memberId = memberId;
            this.name = name;
            this.email = email;
            this.currentLoans = new List<Book>();
        }

        public string MemberId
        {
            get { return memberId; }
            private set { memberId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int CurrentLoanCount
        {
            get { return currentLoans.Count; }
        }

        public bool CanBorrow()
        {
            return currentLoans.Count < MaxBorrowLimit;
        }

        public void AddLoan(Book book)
        {
            currentLoans.Add(book);
        }

        public void RemoveLoan(Book book)
        {
            currentLoans.Remove(book);
        }

        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {memberId} | Name: {name} | Email: {email} | " +
                               $"Books on loan: {currentLoans.Count}/{MaxBorrowLimit}");
        }
    }
}
