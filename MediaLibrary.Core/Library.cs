using System;
using System.Collections.Generic;
namespace MediaLibrary.Core
{
    public class Library
    {
        public List<Item> AllItems = new List<Item>();

        public void DisplayAllTheItems()
        {
            foreach(Item item  in AllItems)
            {
                if (item.Loan)
                {
                    Console.WriteLine(item.Name + " (NOT AVAILABLE)");
                }
                else
                {
                    Console.Write(item.Author + ", ");
                    Console.Write(item.Name + ", ");
                    Console.Write(item.ReleaseDate + ", ");
                    if (item is Book) Console.WriteLine(((Book)item).NumberOfPages);
                    if (item is Movie) Console.WriteLine(((Movie)item).filmStudio);
                    if (item is Audio) Console.WriteLine(((Audio)item).Duration);
                    if (item is VideoGame) Console.WriteLine(((VideoGame)item).MultiplayerCapabilities);
                }
                
            }

        }


        public void organizeByTheType(string type, string property)
        {
            switch(property)
            {
                case "year":
                    AllItems.Sort((x, y) => x.ReleaseDate.CompareTo(y.ReleaseDate));
                    break;
                case "name":
                    AllItems.Sort((x, y) => x.Name.CompareTo(y.Name));
                    break;
                case "author":
                    AllItems.Sort((x, y) => x.Author.CompareTo(y.Author));
                    break;

            }
            foreach (Item item in AllItems)
            {
                switch (type)
                {
                    case "a":
                        {
                            if(item is Audio)
                            {

                                Console.Write(item.Author + ", ");
                                Console.Write(item.Name + ", ");
                                Console.Write(item.ReleaseDate + ", ");
                                Console.Write(item.Loan + ", ");
                                Console.WriteLine(((Audio)item).Duration);
                            }
                        }break;
                    case "v":
                        {
                            if (item is VideoGame)
                            {
                                Console.Write(item.Author + ", ");
                                Console.Write(item.Name + ", ");
                                Console.Write(item.ReleaseDate + ", ");
                                Console.Write(item.Loan + ", ");
                                Console.WriteLine(((VideoGame)item).MultiplayerCapabilities);
                            }
                        }
                        break;
                    case "m":
                        {
                            if (item is Movie)
                            {
                                Console.Write(item.Author + ", ");
                                Console.Write(item.Name + ", ");
                                Console.Write(item.ReleaseDate + ", ");
                                Console.Write(item.Loan + ", ");
                                Console.WriteLine(((Movie)item).filmStudio);
                            }
                        }
                        break;
                    case "b":
                        {
                            if (item is Book)
                            {
                                Console.Write(item.Author + ", ");
                                Console.Write(item.Name + ", ");
                                Console.Write(item.ReleaseDate + ", ");
                                Console.Write(item.Loan + ", ");
                                Console.WriteLine(((Book)item).NumberOfPages);
                            }
                        }
                        break;

                }
            }
        }

        public void SearchByName(string name, string searchType)
        {
            Item itemToFind = null;
            switch (searchType)
            {
                case "a":
                    {
                        itemToFind = AllItems.Find(item => item.Name == name);
                    }break;
                case "b":
                    {
                        itemToFind = AllItems.Find(item => item.ReleaseDate == Convert.ToInt32(name));
                    }
                    break;
                case "c":
                    {
                        itemToFind = AllItems.Find(item => item.Author == name);
                    }
                    break;
            }
            if (itemToFind != null)
            {
                Console.Write(itemToFind.Author + ", ");
                Console.Write(itemToFind.Name + ", ");
                Console.Write(itemToFind.ReleaseDate + ", ");
                if (itemToFind is Book) Console.WriteLine(((Book)itemToFind).NumberOfPages);
                if (itemToFind is Movie) Console.WriteLine(((Movie)itemToFind).filmStudio);
                if (itemToFind is Audio) Console.WriteLine(((Audio)itemToFind).Duration);
                if (itemToFind is VideoGame) Console.WriteLine(((VideoGame)itemToFind).MultiplayerCapabilities);
            }
            else
            {
                Console.WriteLine("Nothing found :(");
            }
        }

    }
}
