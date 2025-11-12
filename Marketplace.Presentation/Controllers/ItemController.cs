using Microsoft.AspNetCore.Mvc;
using Mraketplace.Presention.DTOs.RequestModels;
using Service;

namespace Mraketplace.Presention.Controllers;

[ApiController]
[Route("item-apis")]
public class ItemController : ControllerBase
{
    IItemService _itemService;

    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }
    

    [HttpPost("add-item")]
    public IActionResult AddItem([FromBody] AddItemRequestModel request)
    {
        bool res = _itemService.AddItem(request.Name, request.Price);
        if (res)
            return Ok();
        return BadRequest("Price cannot be a negative number.");
    }

    [HttpDelete("remove-item/{itemId}")]
    public IActionResult RemoveItem(int itemId)
    {
        bool res = _itemService.RemoveItem(itemId);
        if (res)
            return Ok();
        return BadRequest("Item not found.");
    }


    [HttpGet("get-Items")]
    public List<Item> GetItems()
    {
        return _itemService.GetAllItems();
    }
}