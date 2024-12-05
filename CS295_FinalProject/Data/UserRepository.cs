using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public List<User> GetUsers()
    {
        return _context.Users
            .ToList();
    }

    public User GetUserById(int id)
    {
        var user = _context.Users
            .Where(user => user.Id == id)
            .SingleOrDefault();
        return user;
    }
   
    public int StoreUser(User model)
    {
        model.CreateDate = DateTime.Now;
        _context.Users.Add(model);
        return _context.SaveChanges();
        // returns a positive value if successful
    }
}
