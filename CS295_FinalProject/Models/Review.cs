namespace CS295_FinalProject.Models;

public class Review
{
    public int Id { get; set; }
    public User Reviewer { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }
}