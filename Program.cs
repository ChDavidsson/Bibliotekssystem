using System.Net;
using System.Reflection;

namespace Bibliotekssystem;

class Program
{
    static void Main(string[] args)
    {
        List<Bok> books = new List<Bok>();
         

        bool running = true;

        while(running)
        {
            Console.WriteLine("/// Welcome to the library ///");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("3. Search for a book");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option:");

            string val = Console.ReadLine()!;
            Console.WriteLine($"You chose {val}");

            switch(val)
            {
                case "1":
                    Console.WriteLine("What book do you want to add?");
                    Console.WriteLine("Title: ");
                    string title = Console.ReadLine()!.ToLower();
                    Console.WriteLine("Author: ");
                    string author = Console.ReadLine()!.ToLower();
                    Console.WriteLine("Year: ");
                    int year = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("The book you added: \n" + $"Titel: {title} \n" + $"Author: {author} \n" + $"Year: {year} \n");
                    //Want to create a variable so the book gets saved in the list
                    Bok newBook = new Bok(title, author, year);
                    books.Add(newBook);
                    break;
                
                case "2":
                    {
                        if (books.Count == 0)
                        {
                            Console.WriteLine("There are no books in the list");
                        }
                        {
                            foreach (Bok book in books)
                            {
                            Console.WriteLine($"Title: '{book.Title}''{book.YearPublished}' Author: '{book.Author}'");
                            }
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("What book are you looking for?");
                    string lookBook = Console.ReadLine()!.ToLower();
                
                    bool found = false;

                    foreach (Bok book in books)
                    {    
                        if (book.Title!.Equals(lookBook))
                        {
                            Console.WriteLine($"You searched for the book '{lookBook}', it was published in {book.YearPublished} and written by {book.Author}.");
                            found = true;
                        }
                    }

                    if (found == false)
                    {
                        Console.WriteLine("That book does not exist in the library");
                    }   
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
            }
        }
    }
}
