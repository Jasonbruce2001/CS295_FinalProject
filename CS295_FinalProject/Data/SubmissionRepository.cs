using CS295_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CS295_FinalProject.Data;

public class SubmissionRepository : ISubmissionRepository
{
    private readonly ApplicationDbContext _context;

    public SubmissionRepository(ApplicationDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public List<Submission> GetAllSubmissions()
    {
        var submissions = _context.Submissions
            .Include(submission => submission.Username) // returns Review.AppUser object
            .ToList<Submission>();
        return submissions;
    }
   
    public Submission GetSubmissionById(int id)
    {
        var submission = _context.Submissions
            .Include(submission => submission.Username) // returns Review.AppUser object
            .Where(submission => submission.Id == id)
            .SingleOrDefault();
        return submission;
    }
   
    public int StoreSubmission(Submission model)
    {
        model.Date = DateOnly.FromDateTime(DateTime.Today);
        _context.Submissions.Add(model);
        return _context.SaveChanges();
        // returns a positive value if successful
    }
}