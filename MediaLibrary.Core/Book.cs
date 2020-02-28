using System;
namespace MediaLibrary.Core
{
    public class Book : Item
    {
        public int NumberOfPages;

        public Book(string Name, string Author, int ReleaseDate, bool Loan, int NumberOfPages)
        {
            this.Name = Name;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.Loan = Loan;
            this.NumberOfPages = NumberOfPages;
        }
    }
}
