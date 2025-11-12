
namespace Service;

public interface IItemService
{
    bool AddItem(String name, double price);
    bool RemoveItem(int id);
    List<Item> GetAllItems();
    
}