namespace CS295_FinalProject.Models;

public class Review
{
    public int Id { get; set; }
    public User Reviewer { get; set; }
    public int Score { get; set; }
    public string Text { get; set; }
    public DateOnly Date { get; set; }
}