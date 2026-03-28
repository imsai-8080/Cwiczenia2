namespace Cwiczenia2;

public class User
{
    private static int _counter = 0;
    private static List<User> _users = new List<User>();
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserType UserType { get; set; }

    public User(string firstName, string lastName, UserType userType)
    {
        Id = _counter++;
        FirstName = firstName;
        LastName = lastName;
        UserType = userType;
        _users.Add(this);
    }
    
    public static List<User> GetUserList(){
        return _users;
    }
}