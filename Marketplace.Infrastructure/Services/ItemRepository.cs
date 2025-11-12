using Marketplace.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Infrustructure.Services;

public class ItemRepository : IItemRepository
{
    private DatabaseManager _db = new DatabaseManager();

    public void AddItem(Item item)
    {
        _db.Items.Add(item);
        _db.SaveChanges();
    }

    public bool RemoveItem(int id)
    {
        if (_db.Items.Remove(_db.Items.FirstOrDefault(i => i.ItemId == id)) == null)
        {
            return false;
        }

        _db.Items.Remove(_db.Items.FirstOrDefault(i => i.ItemId == id));
        _db.SaveChanges();
        return true;
    }

    public List<Item> GetAllItems()
    {
        return _db.Items
            .Include(i => i.Users)
            .ToList();
    }
}