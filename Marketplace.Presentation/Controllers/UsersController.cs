using Microsoft.AspNetCore.Mvc;
using Mraketplace.Presention.DTOs.RequestModels;
using Service;

namespace Mraketplace.Presention.Controllers;

[ApiController]
[Route("user-apis")]
public class UsersController : ControllerBase
{
    IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public IActionResult LoginUser([FromBody] LoginRequestModel loginRequest)
    {
        bool res = _userService.Login(loginRequest.Username, loginRequest.Password);
        if (res)
            return Ok();
        return BadRequest("Username or password is incorrect");
    }

    [HttpPost("register")]
    public IActionResult RegisterUser([FromBody] LoginRequestModel loginRequest)
    {
         bool res = _userService.SinUp(loginRequest.Username, loginRequest.Password);
         if (res)
             return Ok();
         return BadRequest("Username already exists.");
    }

    [HttpPut("increase")]
    public IActionResult IncreaseBalance([FromBody] IncreaseBalanceRequestModel increaseBalanceRequest)
    {
        bool res = _userService.IncreaseBalance(increaseBalanceRequest.Amount);
        if (res)
            return Ok();
        return BadRequest("Amount annot be a negative number.");
    }

    [HttpPost("buy-item/{itemId}")]
    public IActionResult BuyItem([FromRoute] int itemId)
    {
        bool res = _userService.BuyItem(itemId);
        if (res)
            return Ok();
        return BadRequest("The price of the item is more than the account balance.");
    }

    [HttpGet("get-balance")]
    public double GetBalance()
    {
        return _userService.GetBalance();
    }


    [HttpGet("get-items")]
    public List<Item> GetItems()
    {
        return _userService.GetItemsOfUser();
    }


}