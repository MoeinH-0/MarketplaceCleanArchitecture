using Microsoft.AspNetCore.Mvc;
using Mraketplace.Presention.DTOs.RequestModels;
using Service;

namespace Mraketplace.Presention.Controllers;

[ApiController]
[Route("item-apis")]
public class ItemController : ControllerBase
{
    ItemService _itemService;

    public ItemController(ItemService itemService)
    {
        _itemService = itemService;
    }


    [HttpPost("add-item")]
    public void AddItem([FromBody] AddItemRequestModel request)
    {
        _itemService.AddItem(request.Name, request.Price);
    }

    [HttpDelete("remove-item/{itemId}")]
    public void RemoveItem(int itemId)
    {
        _itemService.RemoveItem(itemId);
    }


    [HttpGet("get-Items")]
    public List<Item> GetItems()
    {
        return _itemService.GetAllItems();
    }
}