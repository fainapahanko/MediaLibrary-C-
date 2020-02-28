using System;
using System.IO;
using System.Collections.Generic;
/*
 + name
+ author 
+ releaseDate
+ loan

    + readAllTheItems()
+ organizeByTheType()
+ filterByParameter()
+ sortByYearOrName()
*/

namespace MediaLibrary.Core
{
    public class Item
    {
        public string Name;
        public string Author;
        public int ReleaseDate;
        public bool Loan;

        //public Item(string Name, string Author, int ReleaseDate, bool Loan)
        //{
        //    this.Name = Name;
        //    this.Author = Author;
        //    this.ReleaseDate = ReleaseDate;
        //    this.Loan = Loan;
        //}

        public void writeAllTheItems(Library library)
        {
            try
            {
                using (var reader = new StreamReader(@"../../../../Media_Library_Database.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var file = reader.ReadToEnd();
                        var values = file.Split("\n");

                        foreach(string value in values)
                        { 
                            var type = value.Split(';');
                            switch (type[0])
                            {
                                case "B":
                                    library.AllItems.Add(new Book(type[1], type[2], Convert.ToInt32(type[4]), Convert.ToBoolean(type[5]), Convert.ToInt32(type[3])));
                                    break;
                                case "M":
                                    library.AllItems.Add(new Movie(type[1], type[2], Convert.ToInt32(type[4]), Convert.ToBoolean(type[5]), type[3]));
                                    break;
                                case "A":
                                    library.AllItems.Add(new Audio(type[1], type[2], Convert.ToInt32(type[4]), Convert.ToBoolean(type[5]), type[3]));
                                    break;
                                case "V":
                                    library.AllItems.Add(new VideoGame(type[1], type[2], Convert.ToInt32(type[4]), Convert.ToBoolean(type[5]), Convert.ToBoolean(type[3])));
                                    break;
                                default:
                                    return;
                            }

                        }

                    }
                }
            } catch(Exception err)
            {
                Console.WriteLine(err);
            }

        }

        public void addItem(string type, string name, string author, string realeaseDate, string specialField)
        {
            string newFileName = "D:\\\\Documents\\coding\\MediaLibrary\\Media_Library_Database.csv";

            string itemToAdd = type + ";" + name + ";" + author + ";" + specialField + ";" + realeaseDate + ";FALSE";

            File.AppendAllText(newFileName, itemToAdd);
        }

    }
}
