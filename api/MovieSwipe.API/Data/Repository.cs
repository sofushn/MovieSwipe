using MovieSwipe.API.GraphModels;

namespace MovieSwipe.API.Data;

public class Repository : IRepository
{
    private static readonly IList<Models.Movie> _movies = new List<Models.Movie>()
    {
        new(Guid.NewGuid(), "The Shawshank Redemption", "1994", "https://pics.filmaffinity.com/The_Shawshank_Redemption-576140557-large.jpg", new Models.Tag[] { new("Drama") }),
        new(Guid.NewGuid(), "The Dark Knight", "2008", "https://pics.filmaffinity.com/the_dark_knight-102763119-large.jpg", new Models.Tag[] { new("Drama"), new("Crime"), new("Action") }),
        new(Guid.NewGuid(), "The Godfather", "1972", "https://pics.filmaffinity.com/the_godfather-488102675-large.jpg", new Models.Tag[] { new("Drama"), new("Crime") })
    };

    private static readonly IList<Models.User> _users = new List<Models.User>()
    {
        new(new Guid("42eb19be-a132-4571-816b-9435f582e27d"), "Test User", new DateTime(2000, 10, 4), "user@test.net"),
        new(Guid.NewGuid(), "Luke Skywalker", DateTime.Today, "Luke@Skywalker.com")
    };

    private static readonly IList<Models.Group> _groups = new List<Models.Group>()
    {
        new(Guid.NewGuid(), "World Champions", "#D0B132", _users, new Models.Tag[] { new("Crime"), new("Anime"), new("Drama") }),
        new(Guid.NewGuid(), "World non-Champions", "#31CEFA", new[] { _users.First() }, new Models.Tag[] { new("Action") }),
        new(Guid.NewGuid(), "The ooooo clan", "#FC3E36", new[] { _users.First() }, new Models.Tag[] { new("Drama") })
    };

    public User GetUser(string email)
    {
        Models.User user = _users.First(x => x.Email == email);
        return new User(user.Id, user.Name, user.Birthdate, user.Email);
    }

    public IEnumerable<Group> GetGroups(Guid userId)
    {
        return _groups
            .Where(g => g.Users.Any(u => u.Id == userId))
            .Select(x => new Group(x.Id, x.Name, x.ColorCode));
    }

    public Movie GetMovie(Guid id)
    {
        Models.Movie movie = _movies.First(x => x.Id == id);
        return new Movie(movie.Id, movie.ReleaseYear, movie.Title, movie.MoviePoster);
    }

    public Movie GetRandomMovie()
    {
        Random random = new(DateTime.Now.Millisecond);
        Models.Movie movie = _movies[random.Next(0, _movies.Count)];
        return new Movie(movie.Id, movie.ReleaseYear, movie.Title, movie.MoviePoster);
    }

    public IEnumerable<Tag> GetGroupTags(Guid groupId)
    {
        return _groups
            .First(g => g.Id == groupId)
            .Tags
            .Select(t => new Tag(t.Name));
    }

    public IEnumerable<Tag> GetMovieTags(Guid movieId)
    {
        return _movies
            .First(m => m.Id == movieId)
            .Tags
            .Select(t => new Tag(t.Name));
    }

    public Group GetGroup(Guid groupId)
    {
        Models.Group group = _groups.First(g => g.Id == groupId);
        return new Group(group.Id, group.Name, group.ColorCode);
    }
}