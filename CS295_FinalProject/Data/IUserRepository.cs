using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public interface IUserRepository
{
    public List<User> GetUsers();
    public User GetUserById(int id); // Returns a model object
    public int StoreUser(User model);   
}