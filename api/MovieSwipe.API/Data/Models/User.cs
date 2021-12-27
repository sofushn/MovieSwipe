namespace MovieSwipe.API.Data.Models;

public class User
{
    public User(Guid id, string name, DateTime birthdate, string email)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Email = email;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public string Email { get; set; }
}
