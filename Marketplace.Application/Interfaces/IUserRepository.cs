namespace Service.Interfaces.Repsitoreis;

public interface IUserRepository
{
    public bool AddUserToDataBase(User user);
    public bool LoginUser(string username, string password);
    
    bool BuyItem(int itemId);
    
    void IncreaseBalance(double amount);
    
    double GetBalance();
    
    List<Item> GetItemsOfUser();
}