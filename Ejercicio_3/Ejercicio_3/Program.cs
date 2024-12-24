public interface IRepository<T>
{
    void Add(T item);

    T Get(int id);
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class UserRepository : IRepository<User>
{
    private readonly Dictionary<int, User> users = new Dictionary<int, User>();

    public void Add(User user)
    {
        users[user.Id] = user;
    }

    public User Get(int id)
    {
        users.TryGetValue(id, out User user);
        return user;
    }
}

// Uso
public class Program
{
    public static void Main()
    {
        UserRepository userRepository = new UserRepository();
        userRepository.Add(new User { Id = 1, Name = "John" });
        User user = userRepository.Get(1);
        Console.WriteLine($"User: {user.Name}"); // Output: User: John
    }
}