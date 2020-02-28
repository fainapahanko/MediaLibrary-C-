using System;
using MediaLibrary.Core;

namespace MediaLibrary.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library library = new Library();
            Item item = new Item();
            item.writeAllTheItems(library);
            int option;
            do
            {
                do
                {
                    Console.WriteLine("Choose an option: \n1 - Display all the media\n2 - Display by category\n3 - Search media\n4 - Add media\n5 - Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                } while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5);

                switch (option)
                {
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                    case 1:
                        {
                            library.DisplayAllTheItems();
                        }
                        break;
                    case 2:
                        {
                            string type;
                            string filter;
                            do
                            {
                                Console.WriteLine("Please choose a kind of media \na - Audio\nb - Book\nm - Movie\nv - VideoGame");
                                type = Console.ReadLine();
                            } while (type != "a" && type != "b" && type != "m" && type != "v");
                            do
                            {
                                Console.WriteLine("Please choose a filter year | name | author");
                                filter = Console.ReadLine();
                            } while (filter != "year" && filter != "name" && filter != "author");
                            library.organizeByTheType(type, filter);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Choose a search type: \na - By Name\nb - By year\nc - By author");
                            string searchType = Console.ReadLine();
                            Console.WriteLine("Search: ");
                            string name = Console.ReadLine();
                            library.SearchByName(name, searchType);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Choose a search type: \nB - Book\nA - Audio\nM - Movie\nV - VideoGame");
                            string type = Console.ReadLine();
                            Console.Write("Choose a name: ");
                            string name = Console.ReadLine();
                            Console.Write("Choose a author: ");
                            string author = Console.ReadLine();
                            Console.Write("Choose a year: ");
                            string year = Console.ReadLine();
                            switch (type)
                            {
                                case "B":
                                    Console.Write("Specify a number of pages: ");
                                    break;
                                case "A":
                                    Console.Write("Specify a duration: ");
                                    break;
                                case "M":
                                    Console.Write("Specify a name of a film Studio: ");
                                    break;
                                case "V":
                                    Console.Write("Specify if there is a Multiplayer Capabilities (TRUE || FALSE): ");
                                    break;
                            }
                            string specialField = Console.ReadLine();
                            item.addItem(type, name, author, year, specialField);
                        }
                        break;
                }
            } while (option != 5);
        }
    }
}
