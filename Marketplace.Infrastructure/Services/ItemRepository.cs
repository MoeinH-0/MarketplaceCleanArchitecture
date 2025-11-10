using Marketplace.Application.Interfaces;

namespace Marketplace.Infrustructure.Services;

public class ItemRepository : IItemRepository
{
    private DatabaseManager _db = new DatabaseManager();
    public void AddItem(Item item)
    {
        _db.Items.Add(item);
        _db.SaveChanges();
    }

    public void RemoveItem(int id)
    {
        _db.Items.Remove(_db.Items.FirstOrDefault(i => i.ItemId == id));
        _db.SaveChanges();
    }

    public List<Item> GetAllItems()
    {
        return _db.Items.ToList();
    }
}