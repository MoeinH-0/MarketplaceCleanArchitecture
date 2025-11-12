using Service.Interfaces.Repsitoreis;
using Marketplace.Domain;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Infrustructure.Services;

public class UserRepository : IUserRepository
{
    private readonly DatabaseManager _db = new DatabaseManager();
    public bool AddUserToDataBase(User user)
    {
        if (_db.Users.FirstOrDefault(u => u.Username == user.Username) != null)
            return false;
        
        _db.Users.Add(user);
        CurrentUser.Id = user.UserId;
        _db.SaveChanges();
        return true;
    }

    public bool LoginUser(string username, string password)
    {
        if (_db.Users.FirstOrDefault(u => u.Username == username && u.Password == password) == null)
            return false;
        
        CurrentUser.Id = _db.Users.First(u => u.Username == username && u.Password == password).UserId;
        return true;
    }

    public bool BuyItem(int itemId)
    {
        var user = _db.Users.FirstOrDefault(u => u.UserId == CurrentUser.Id);
        var item = _db.Items.FirstOrDefault(i => i.ItemId == itemId);
        if (user == null || item == null)
            return false;

        if (user.Balance < item.Price)
            return false;
        
        user.Balance -= item.Price;
        
        user.Items.Add(item);
        
        _db.SaveChanges();
        return true;
    }

    public void IncreaseBalance(double amount)
    {
        var user = _db.Users.FirstOrDefault(u => u.UserId == CurrentUser.Id);
        if (user != null)
        {
            user.Balance += amount;
        }
        _db.SaveChanges();
    }

    public double GetBalance()
    {
        return _db.Users.FirstOrDefault(u => u.UserId == CurrentUser.Id)!.Balance;
    }

    public List<Item> GetItemsOfUser()
    {

        return _db.Users.Include(u => u.Items).FirstOrDefault(u => u.UserId == CurrentUser.Id)!.Items;
    }
}