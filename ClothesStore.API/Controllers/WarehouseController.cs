using Microsoft.AspNetCore.Mvc;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehouseController : ControllerBase
{
    private readonly IEntityService<Warehouse> _warehouseEntityService;

    public WarehouseController(IEntityService<Warehouse> warehouseEntityService)
    {
        _warehouseEntityService = warehouseEntityService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Warehouse>> GetAllWarehouse()
    {
        var warehouse = _warehouseEntityService.GetAll();
        return Ok(warehouse);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<Warehouse>> GetWarehouseById(Guid warehouseId)
    {
        Warehouse warehouse = _warehouseEntityService.GetById(warehouseId);
        return Ok(warehouse);
    }

    [HttpPost]
    public void CreateWarehouse(Warehouse warehouse)
    {
        _warehouseEntityService.Create(warehouse);
    }
}