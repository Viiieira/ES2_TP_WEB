namespace web.Models;

public class User
{
    public User()
    {
    }

    public User(string username, string password, string firstName, string lastName, string country, string city,
        string email, string role)
    {
        Username = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Country = country;
        City = city;
        Email = email;
        Role = role;
    }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }
}