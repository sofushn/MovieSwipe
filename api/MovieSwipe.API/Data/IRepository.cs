using System.Collections.Generic;
using MovieSwipe.API.GraphModels;

namespace MovieSwipe.API.Data;

public interface IRepository
{
    User GetUser(string email);
    IEnumerable<Group> GetGroups(Guid userId);
    Movie GetMovie(Guid id);
    Movie GetRandomMovie();
    IEnumerable<Tag> GetGroupTags(Guid groupId);
    IEnumerable<Tag> GetMovieTags(Guid movieId);
    Group GetGroup(Guid groupId);
}