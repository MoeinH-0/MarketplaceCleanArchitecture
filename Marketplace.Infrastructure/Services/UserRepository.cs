using Service.Interfaces.Repsitoreis;

namespace Marketplace.Infrustructure.Services;

public class UserRepository : IUserRepository
{
    public bool AddUserToDataBase(User user)
    {
        throw new NotImplementedException();
    }

    public bool LoginUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public bool BuyItem(int itemId, int userId)
    {
        throw new NotImplementedException();
    }

    public List<Item> GetItemsOfUser()
    {
        throw new NotImplementedException();
    }
}