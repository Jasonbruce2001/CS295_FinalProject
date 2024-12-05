using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public interface IReviewRepository
{
    public List<Review> GetAllReviews();  // Returns all review objects
    public Review GetReviewById(int id); // Returns a model object
    public int StoreReview(Review model);  // Saves a model object to the db
}