using Microsoft.AspNetCore.Mvc;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IEntityService<Order> _orderEntityService;

    public OrderController(IEntityService<Order> orderEntityService)
    {
        _orderEntityService = orderEntityService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Order>> GetAllOrder()
    {
        var orders = _orderEntityService.GetAll();
        return Ok(orders);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<Order>> GetOrderById(Guid orderId)
    {
        Order order = _orderEntityService.GetById(orderId);
        return Ok(order);
    }

    [HttpPost]
    public void Create(Order order)
    {
        _orderEntityService.Create(order);
    }
}