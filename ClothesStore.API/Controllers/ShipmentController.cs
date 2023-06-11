using Microsoft.AspNetCore.Mvc;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ShipmentController : ControllerBase
{
    private readonly IEntityService<Shipment> _shipmentEntityService;

    public ShipmentController(IEntityService<Shipment> shipmentEntityService)
    {
        _shipmentEntityService = shipmentEntityService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Shipment>> GetAllShipment()
    {
        var shipments = _shipmentEntityService.GetAll();
        return Ok(shipments);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<Shipment>> GetShipmentById(Guid shipmentId)
    {
        Shipment shipment = _shipmentEntityService.GetById(shipmentId);
        return Ok(shipment);
    }

    [HttpPost]
    public void CreateShipment(Shipment shipment)
    {
        _shipmentEntityService.Create(shipment);
    }
}