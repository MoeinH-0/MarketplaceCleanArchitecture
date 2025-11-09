using System.ComponentModel.DataAnnotations;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public List<User> Users { get; set; } = new();
}