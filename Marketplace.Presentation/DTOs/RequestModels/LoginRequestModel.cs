namespace Mraketplace.Presention.DTOs.RequestModels;

public class LoginRequestModel(string username, string password)
{
    public string Username { set; get; } = username;
    public string Password { set; get; } = password;
}