using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public class SeedData
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Users.Any())  // this is to prevent adding duplicate data
        {
            // Create User objects
            User user1 = new User { Name = "Jason Bruce" };
            user1.CreateDate = DateOnly.FromDateTime(DateTime.Now);
            User user2 = new User { Name = "Michael Rozanski" };
            user2.CreateDate = DateOnly.FromDateTime(DateTime.Now);
            User user3 = new User { Name = "Patches" };
            user3.CreateDate = DateOnly.FromDateTime(DateTime.Now);
            
            // Queue up user objects to be saved to the DB
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            
            // Create Submission objects
            Submission sub1 = new Submission { Name = "Animal Skulls #1", Username = user1, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            Submission sub2 = new Submission { Name = "Human Skull #11", Username = user1, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            Submission sub3 = new Submission { Name = "Example Submission 1", Username = user2, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            Submission sub4 = new Submission { Name = "Example Submission 2", Username = user3, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            
            // Queue up user objects to be saved to the DB
            context.Submissions.Add(sub1);
            context.Submissions.Add(sub2);
            context.Submissions.Add(sub3);
            context.Submissions.Add(sub4);
            
            context.SaveChanges(); // stores all the reviews in the DB
        }
    }
}
