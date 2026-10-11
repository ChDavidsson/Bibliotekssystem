namespace Bibliotekssystem;


public class MenuHelper
{
        Library bookSystem = new Library();
        bool running = true;
        
        public void ShowMenu()
        {
        
        
        while(running)
        {
            Console.WriteLine("/// Welcome to the library ///");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("3. Search for a book");
            Console.WriteLine("4. Loan book");
            Console.WriteLine("5. Return book");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Choose an option:");

            string val = Console.ReadLine()!;
            Console.WriteLine($"You chose {val}");

            switch(val)
            {
                case "1":
                bookSystem.AddBook();
                break;
            
                case "2":
                bookSystem.ShowAllBooks();
                break;
                
                case "3":
                bookSystem.SearchBook();
                break;

                case "4":
                bookSystem.LoanBook();
                break;

                case "5":
                bookSystem.ReturnBook();
                break;
                
                case "6":
                running = false;
                Console.WriteLine("Exiting program...");
                break;

                default:
                Console.WriteLine("Invalid choice, try again!");
                break;
            }
        }
    }
}
    

