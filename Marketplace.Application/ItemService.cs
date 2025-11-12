using Marketplace.Application.Interfaces;

namespace Service;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;
    
    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    
    public bool AddItem(string name, double price)
    {
        if (price < 0)
            return false;
        
        _itemRepository.AddItem(new Item(name, price));
        return true;
    }

    public bool RemoveItem(int id)
    {
        return _itemRepository.RemoveItem(id);
    }

    public List<Item> GetAllItems()
    {
        return _itemRepository.GetAllItems();
    }
}