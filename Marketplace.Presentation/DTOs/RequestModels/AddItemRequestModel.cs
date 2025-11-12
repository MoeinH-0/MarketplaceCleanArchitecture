namespace Mraketplace.Presention.DTOs.RequestModels;

public class AddItemRequestModel(string name, double price)
{
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;
}