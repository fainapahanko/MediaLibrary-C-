using System;
namespace MediaLibrary.Core
{
    public class Movie : Item
    {
        public string filmStudio;

        public Movie(string Name, string Author, int ReleaseDate, bool Loan, string filmStudio) 
        {
            this.Name = Name;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.Loan = Loan;
            this.filmStudio = filmStudio;
        }
    }
}
