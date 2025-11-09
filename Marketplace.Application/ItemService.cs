using Marketplace.Application.Interfaces;

namespace Service;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;
    
    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    
    public void AddItem(string name, double price)
    {
        if (price < 0)
            return;
        
        _itemRepository.AddItem(new Item(name, price));
    }

    public void RemoveItem(int id)
    {
        _itemRepository.RemoveItem(id);
    }

    public List<Item> GetAllItems()
    {
        return _itemRepository.GetAllItems();
    }
}