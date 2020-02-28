using System;
namespace MediaLibrary.Core
{
    public class Audio : Item
    {
        public string Duration;

        public Audio(string Name, string Author, int ReleaseDate, bool Loan, string Duration) 
        {
            this.Name = Name;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.Loan = Loan;
            this.Duration = Duration;
        }
    }
}
