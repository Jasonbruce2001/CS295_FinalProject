namespace CS295_FinalProject.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int QuantityOnHand { get; set; }
    public decimal UnitPrice { get; set; }
}