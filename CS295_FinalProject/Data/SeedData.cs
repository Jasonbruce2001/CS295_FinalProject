using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public class SeedData
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            Product product1 = new Product { Name = "Alvin Drafting Compass", Description = "Professional-grade compass for precise circles", UnitPrice = 18, QuantityOnHand = 12 };
            Product product2 = new Product { Name = "Winsor & Newton Oil Paint", Description = "37ml tube of ultramarine blue", UnitPrice = 12, QuantityOnHand = 30 };
            Product product3 = new Product { Name = "Strathmore Sketch Pad", Description = "9x12 inch, 100 sheets, 60lb weight", UnitPrice = 15, QuantityOnHand = 25 };
            Product product4 = new Product { Name = "Golden Acrylic Paint", Description = "59ml jar of titanium white", UnitPrice = 10, QuantityOnHand = 40 };
            Product product5 = new Product { Name = "Liquitex Matte Medium", Description = "8oz bottle for acrylic painting", UnitPrice = 20, QuantityOnHand = 18 };
            Product product6 = new Product { Name = "Canson Watercolor Paper", Description = "11x15 inch, 30 sheets, 140lb cold press", UnitPrice = 25, QuantityOnHand = 15 };
            Product product7 = new Product { Name = "Prismacolor Premier Colored Pencils", Description = "Set of 24 high-quality colored pencils", UnitPrice = 35, QuantityOnHand = 10 };
            Product product8 = new Product { Name = "Derwent Charcoal Pencils", Description = "Set of 4 charcoal pencils, various shades", UnitPrice = 8, QuantityOnHand = 22 };
            Product product9 = new Product { Name = "Staedtler Technical Pens", Description = "Set of 3 pens with 0.1, 0.3, and 0.5mm tips", UnitPrice = 20, QuantityOnHand = 12 };
            Product product10 = new Product { Name = "Sakura Micron Pen Set", Description = "Set of 6 archival ink pens, black", UnitPrice = 18, QuantityOnHand = 30 };
            Product product11 = new Product { Name = "Pentel Brush Pen", Description = "Waterproof brush pen for calligraphy and illustration", UnitPrice = 15, QuantityOnHand = 28 };
            Product product12 = new Product { Name = "Faber-Castell Kneaded Erasers", Description = "Pack of 3 erasers, ideal for graphite and charcoal", UnitPrice = 5, QuantityOnHand = 50 };
            Product product13 = new Product { Name = "ArtBin Storage Case", Description = "Plastic storage case for art supplies, 16-inch", UnitPrice = 22, QuantityOnHand = 8 };
            Product product14 = new Product { Name = "Royal & Langnickel Brush Set", Description = "Set of 12 synthetic brushes for acrylics", UnitPrice = 30, QuantityOnHand = 16 };
            Product product15 = new Product { Name = "Daler-Rowney Watercolors", Description = "12-color compact set with mixing tray", UnitPrice = 25, QuantityOnHand = 20 };
            Product product16 = new Product { Name = "Arches Watercolor Blocks", Description = "9x12 inch, 20 sheets, 100% cotton", UnitPrice = 45, QuantityOnHand = 12 };
            Product product17 = new Product { Name = "Holbein Gouache Paint", Description = "Set of 12 vibrant opaque colors", UnitPrice = 40, QuantityOnHand = 14 };
            Product product18 = new Product { Name = "Caran d'Ache Neocolor Crayons", Description = "Set of 10 water-soluble wax pastels", UnitPrice = 28, QuantityOnHand = 10 };
            Product product19 = new Product { Name = "Yupo Paper Pad", Description = "11x14 inch, 10 sheets, synthetic watercolor paper", UnitPrice = 20, QuantityOnHand = 25 };
            Product product20 = new Product { Name = "Montana Gold Spray Paint", Description = "400ml can of high-coverage matte spray paint", UnitPrice = 15, QuantityOnHand = 50 };
                
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);
            context.Products.Add(product5);
            context.Products.Add(product6);
            context.Products.Add(product7);
            context.Products.Add(product8);
            context.Products.Add(product9);
            context.Products.Add(product10);
            context.Products.Add(product11);
            context.Products.Add(product12);   
            context.Products.Add(product13);
            context.Products.Add(product14);
            context.Products.Add(product15);
            context.Products.Add(product16);
            context.Products.Add(product17);
            context.Products.Add(product18);
            context.Products.Add(product19);
            context.Products.Add(product20);
            
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
            Submission sub1 = new Submission { Name = "Animal Skull #1", Username = user1, Link = "https://i.imgur.com/TwX7oht.jpeg", Date = DateOnly.Parse("12/1/24") };
            Submission sub2 = new Submission { Name = "Stippled Doberman", Username = user1, Link = "https://i.imgur.com/sJh3SCK.jpeg", Date = DateOnly.Parse("11/21/24") };
            Submission sub3 = new Submission { Name = "Example Submission 1", Username = user2, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            Submission sub4 = new Submission { Name = "Example Submission 2", Username = user3, Link = "https://i.imgur.com/vcYOMu8.jpeg", Date = DateOnly.FromDateTime(DateTime.Now) };
            
            // Queue up user objects to be saved to the DB
            context.Submissions.Add(sub1);
            context.Submissions.Add(sub2);
            context.Submissions.Add(sub3);
            context.Submissions.Add(sub4);
            
            //create review objects
            Review review1 = new Review { Reviewer = user1, Score = 10, Date = DateOnly.Parse("12/1/24"), Text = "I love the large selection here!"};
            Review review2 = new Review { Reviewer = user2, Score = 9, Date = DateOnly.Parse("12/4/24"), Text = "The customer service in the store is great."}; 
            Review review3 = new Review { Reviewer = user3, Score = 9, Date = DateOnly.FromDateTime(DateTime.Now), Text = "This is my favorite neighborhood store." };
            
            // queue review objects to be saved to DB
            context.Reviews.Add(review1);
            context.Reviews.Add(review2);
            context.Reviews.Add(review3);
            
            context.SaveChanges(); // stores all the reviews in the DB
        }
    }
}
