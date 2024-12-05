using CS295_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CS295_FinalProject.Data;

public class ReviewRepository : IReviewRepository
{
    private readonly ApplicationDbContext _context;

    public ReviewRepository(ApplicationDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public List<Review> GetAllReviews()
    {
        var reviews = _context.Reviews
            .Include(review => review.Reviewer) // returns Review.AppUser object
            .ToList<Review>();
        return reviews;
    }
   
    public Review GetReviewById(int id)
    {
        var review = _context.Reviews
            .Include(review => review.Reviewer) // returns Review.AppUser object
            .Where(review => review.Id == id)
            .SingleOrDefault();
        return review;
    }
   
    public int StoreReview(Review model)
    {
        model.Date = DateTime.Now;
        _context.Reviews.Add(model);
        return _context.SaveChanges();
        // returns a positive value if successful
    }
}