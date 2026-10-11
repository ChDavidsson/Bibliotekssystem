namespace Bibliotekssystem;

public class Library
    {
        public List<Bok> books = new List<Bok>();
        
        
        public void AddBook()
        {
            Bok newBook = new Bok();
            Console.WriteLine("What book do you want to add?");
            Console.WriteLine("Title: ");
            newBook.Title = Console.ReadLine()!;
            Console.WriteLine("Author: ");
            newBook.Author = Console.ReadLine();
            Console.WriteLine("Year: ");
            newBook.YearPublished = int.Parse(Console.ReadLine()!);
            Console.WriteLine("The book you added: \n" + $"Title: {newBook.Title} \n" + $"Author: {newBook.Author} \n" + $"Year: {newBook.YearPublished} \n");
            //Add the new book to the list
            books.Add(newBook);
        }

        public void ShowAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("There are no books in the list");
                return;
            }

            bool found = false;

            foreach (Bok book in books)
            {
                if (!book.IsLoaned)
                {
                    Console.WriteLine($"Title: '{book.Title}''{book.YearPublished}' Author: '{book.Author}'");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("There currently are no books to loan");
            }
            
        }

        public void SearchBook()
        {
            Console.WriteLine("What book are you looking for?");
            string searchBook = Console.ReadLine()!;
        
            bool found = false;

            foreach (Bok book in books)
            {    
                if (book.Title!.Equals(searchBook, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"You searched for the book '{searchBook}', it was published in {book.YearPublished} and written by {book.Author}.");
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("That book does not exist in the library");
            }   
        }

        public void LoanBook()
        {

            if (books.Count == 0)
            {
                Console.WriteLine("There are currently no books to loan");
                return;
            }

            Console.WriteLine("What book do you want to loan?");
            string loanBook = Console.ReadLine()!;

            bool found = false;

            foreach (Bok book in books)
            {
                if (book.Title!.Equals(loanBook, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    if (book.IsLoaned)
                    {
                        Console.WriteLine("That books is already loaned");
                    }
                    else
                    {
                        book.IsLoaned = true;
                        Console.WriteLine($"You have loaned {loanBook} by {book.Author}");
                    }

                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("That book does not exist in the library");
            }
        
        }

        public void ReturnBook()
        {
            Console.WriteLine("What book do you want to return?");
            string returnBook = Console.ReadLine()!;

            bool found = false;

            foreach (Bok book in books)
            {
                if (book.Title!.Equals(returnBook, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    if (book.IsLoaned)
                    {
                        book.IsLoaned = false;
                        Console.WriteLine($"You have returned {returnBook} by {book.Author}");
                    }
                    else
                    {
                        Console.WriteLine("That book was not loaned");
                    }

                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("That book does not exist in the library");
            }
        }
    }
