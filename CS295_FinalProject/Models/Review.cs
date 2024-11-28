namespace CS295_FinalProject.Models;

public class Review
{
    public int ReviewId { get; set; }
    public string Name { get; set; }
    public string Text { get; set; }
    public DateOnly Date { get; set; }
}