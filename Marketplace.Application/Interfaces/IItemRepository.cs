namespace Marketplace.Application.Interfaces;

public interface IItemRepository
{
    void AddItem(Item item);
    void RemoveItem(int id);
    List<Item> GetAllItems();
}