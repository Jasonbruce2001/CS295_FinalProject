namespace CS295_FinalProject.Models;

public class Submission
{
    public int Id { get; set; }
    public string Name { get; set; }
    public User Username { get; set; }
    public DateOnly Date { get; set; }
    public string Link { get; set; } //a link to a publicly hosted image to be displayed
}