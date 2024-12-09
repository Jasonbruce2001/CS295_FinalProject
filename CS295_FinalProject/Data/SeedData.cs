using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public class SeedData
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            Product product1 = new Product { Name = "Adjustable Wooden Easel", Description = "Full pine adjustable easel with carrying case" +
                                             "and folds down completely. Full height is 5 feet 6 inches", UnitPrice = 160, QuantityOnHand = 6 };
            Product product2 = new Product { Name = "Artist Loft Brush Set", Description = "7 piece synthetic brush set perfect for beginners", 
                                             UnitPrice = 25, QuantityOnHand = 20 };
            Product product3 = new Product { Name = "General Mills Charcoal", Description = "2 piece compressed charcoal stick pack", UnitPrice = 5, QuantityOnHand = 50 };
            Product product4 = new Product { Name = "Titanium White Acrylic Paint", Description = "100ml tube by Winsor and Newton", UnitPrice = 10, QuantityOnHand = 32 };
            Product product5 = new Product { Name = "12x24 Cotton Canvas Panel", Description = "100% cotton stretched canvas, pre primed for acrylic paint", 
                                             UnitPrice = 8, QuantityOnHand = 24 };
            
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);
            context.Products.Add(product5);
            
            context.SaveChanges();
        }
        
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
