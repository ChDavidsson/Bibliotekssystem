namespace Bibliotekssystem;

public class Bok
{
    // Titel (string)
    public string? Title {get; set;}

    // Författare (string)
    public string? Author {get; set;}

    // YearPublished (int)
    public int YearPublished {get;set;}

    public Bok (string title, string author, int yearpublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearpublished;
        }
}
