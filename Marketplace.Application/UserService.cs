using System.Text.RegularExpressions;
using Service.Interfaces.Repsitoreis;

namespace Service;

public class UserService : IUserService
{
    
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public bool Login(string username, string password)
    {
        if (Regex.IsMatch(username, @"^[A-Za-z0-9_]{3,30}$")
            && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
        {
            return _userRepository.LoginUser(username, password);
        }

        return false;
    }

    public bool SinUp(string username, string password)
    {
        if (Regex.IsMatch(username, @"^[A-Za-z0-9_]{3,30}$")
            && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
        {
            return _userRepository.AddUserToDataBase(new User(username, password));
        }

        return false;
    }

    public bool BuyItem(int itemId, int userId)
    {
        return _userRepository.BuyItem(itemId, userId);
    }
    
    public List<Item> GetItemsOfUser()
    {
        return _userRepository.GetItemsOfUser();
    }
}