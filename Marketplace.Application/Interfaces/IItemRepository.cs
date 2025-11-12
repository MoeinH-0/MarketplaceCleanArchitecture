namespace Marketplace.Application.Interfaces;

public interface IItemRepository
{
    void AddItem(Item item);
    bool RemoveItem(int id);
    List<Item> GetAllItems();
}