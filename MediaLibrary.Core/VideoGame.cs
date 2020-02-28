using System;
namespace MediaLibrary.Core
{
    public class VideoGame : Item
    {
        public bool MultiplayerCapabilities;

        public VideoGame(string Name, string Author, int ReleaseDate, bool Loan, bool MultiplayerCapabilities) 
        {
            this.Name = Name;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.Loan = Loan;
            this.MultiplayerCapabilities = MultiplayerCapabilities;
        }

    }
}
