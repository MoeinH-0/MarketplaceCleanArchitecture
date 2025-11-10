
namespace Service;

public interface IUserService
{
    public bool Login(string username, string password);
    
    public bool SinUp(string username, string password);
    
    bool BuyItem(int itemId);
    
    List<Item> GetItemsOfUser();
    
    void IncreaseBalance(double amount);
    
}