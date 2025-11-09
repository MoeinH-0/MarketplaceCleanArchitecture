namespace Service.Interfaces.Repsitoreis;

public interface IUserRepository
{
    public bool AddUserToDataBase(User user);
    public bool LoginUser(string username, string password);
    
    bool BuyItem(int itemId, int userId);
    
    List<Item> GetItemsOfUser();
}