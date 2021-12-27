using HotChocolate;
using MovieSwipe.API.Data;

namespace MovieSwipe.API.GraphModels;

public class Query
{
    public User GetUser([Service] IRepository repository, string email) => repository.GetUser(email);
    public Movie GetMovie([Service] IRepository repository, Guid id) => repository.GetMovie(id);
    public Group GetGroup([Service] IRepository repository, Guid id) => repository.GetGroup(id);
}

public class User
{
    public User(Guid id, string name, DateTime birthdate, string email)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Email = email;
    }

    Guid Id { get; set; }
    public string Name { get; }
    public DateTime Birthdate { get; set; }
    public string Email { get; set; }

    public IEnumerable<Group> GetGroups([Service] IRepository repository) => repository.GetGroups(Id);
}

public class Movie
{
    public Movie(Guid id, string releaseYear, string title, string moviePoster)
    {
        Id = id;
        ReleaseYear = releaseYear;
        Title = title;
        MoviePoster = moviePoster;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string ReleaseYear { get; set; }
    public string MoviePoster { get; set; }

    public IEnumerable<Tag> GetTags([Service] IRepository repository) => repository.GetMovieTags(Id);
}

public class Group
{
    public Group(Guid id, string name, string colorCode)
    {
        Id = id;
        Name = name;
        ColorCode = colorCode;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ColorCode { get; set; }

    public Movie GetRandomMovie([Service] IRepository repository) => repository.GetRandomMovie();
    public IEnumerable<Tag> GetTags([Service] IRepository repository) => repository.GetGroupTags(Id);
}
public class Tag
{
    public Tag(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
