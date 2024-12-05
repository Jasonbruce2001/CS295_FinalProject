using Microsoft.EntityFrameworkCore;
using CS295_FinalProject.Models;

namespace CS295_FinalProject;

public class ApplicationDbContext : DbContext
{
    // constructor just calls the base class constructor
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options) { }
  
    // one DbSet for each domain model class
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Submission> Submissions { get; set; }
    public DbSet<User> Users { get; set; }
}