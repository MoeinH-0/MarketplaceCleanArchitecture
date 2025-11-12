namespace Mraketplace.Presention.DTOs.RequestModels;

public class BuyItemRequestModel(int itemId)
{
    public int ItemId { get; set; } =  itemId;
}
