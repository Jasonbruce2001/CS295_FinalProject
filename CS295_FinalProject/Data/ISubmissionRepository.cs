using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public interface ISubmissionRepository
{
    public List<Submission> GetAllSubmissions();  // Returns all review objects
    public Submission GetSubmissionById(int id); // Returns a model object
    public int StoreSubmission(Submission model);  // Saves a model object to the db
}