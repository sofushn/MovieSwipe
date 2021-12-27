namespace MovieSwipe.API.Data.Models;

public class Group
{
    public Group(Guid id, string name, string colorCode, ICollection<User> users, ICollection<Tag> tags)
    {
        Id = id;
        Name = name;
        ColorCode = colorCode;
        Users = users;
        Tags = tags;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ColorCode { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<Tag> Tags { get; set; }
}
