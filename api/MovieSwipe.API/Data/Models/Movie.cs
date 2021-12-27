namespace MovieSwipe.API.Data.Models;

public class Movie
{
    public Movie(Guid id, string title, string releaseYear, string moviePoster, ICollection<Tag> tags)
    {
        Id = id;
        Title = title;
        ReleaseYear = releaseYear;
        MoviePoster = moviePoster;
        Tags = tags;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string ReleaseYear { get; set; }
    public string MoviePoster { get; set; }
    public ICollection<Tag> Tags { get; set; }
}
