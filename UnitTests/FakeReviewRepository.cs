using CS295_FinalProject.Data;
using CS295_FinalProject.Models;

namespace UnitTests;

public class FakeReviewRepository
{
    public class FakeReview : IReviewRepository
    {
        private List<Review> Reviews { get; set; } = new List<Review>();
        
        public List<Review> GetAllReviews()
        {
            return Reviews;
        }

        public Review GetReviewById(int id)
        {
            return Reviews[id];
        }

        public int StoreReview(Review model)
        {
            int status = 0;
            
            if (model != null)
            {
                model.Id = Reviews.Count + 1;
                Reviews.Add(model);
                status = 1;
            }

            return status;
        }
    }
}