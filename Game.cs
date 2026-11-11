public class Game
{
    public string Title;
    public string Genre;
    public int Year;
    public double Rating;
    public bool Complete;

    public Game(string title, string genre, int year, double rating)
    {
        Title = title;
        Genre = genre;
        Year = year;
        Rating = rating;
        Complete = false;
    }
}