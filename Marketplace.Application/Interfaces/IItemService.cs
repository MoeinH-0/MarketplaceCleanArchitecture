
namespace Service;

public interface IItemService
{
    void AddItem(String name, double price);
    void RemoveItem(int id);
    List<Item> GetAllItems();
    
}