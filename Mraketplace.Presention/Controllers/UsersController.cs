using Microsoft.AspNetCore.Mvc;
using Mraketplace.Presention.DTOs.RequestModels;
using Service;

namespace Mraketplace.Presention.Controllers;

[ApiController]
[Route("user-apis")]
public class UsersController : ControllerBase
{
    UserService _userService;

    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public bool LoginUser([FromBody] LoginRequestModel loginRequest)
    {
        return _userService.Login(loginRequest.Username, loginRequest.Password);
    }

    [HttpPost("register")]
    public bool RegisterUser([FromBody] LoginRequestModel loginRequest)
    {
        return _userService.SinUp(loginRequest.Username, loginRequest.Password);
    }

    [HttpPut("increase")]
    public void IncreaseBalance([FromBody] IncreaseBalanceRequestModel increaseBalanceRequest)
    {
        _userService.IncreaseBalance(increaseBalanceRequest.Amount);
    }

    [HttpPost("buy-item/{itemId}")]
    public void BuyItem([FromRoute] int itemId)
    {
        _userService.BuyItem(itemId);
    }


}