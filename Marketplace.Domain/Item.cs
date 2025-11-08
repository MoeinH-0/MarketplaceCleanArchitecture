using System.ComponentModel.DataAnnotations;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Item(int itemId, string name, double price)
    {
        ItemId = itemId;
        Name = name;
        Price = price;
    }

    public List<User> Users { get; set; } = new();
}