using ClothesStore.API.Services;
using ClothesStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductItemController : ControllerBase
{
    private readonly IEntityService<ProductItem> _productsEntityService;

    public ProductItemController(IEntityService<ProductItem> productsEntityService)
    {
        _productsEntityService = productsEntityService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<ProductItem>> GetAllProduct()
    {
        var products = _productsEntityService.GetAll();
        return Ok(products);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<ProductItem>> GetProductById(Guid productId)
    {
        ProductItem product = _productsEntityService.GetById(productId);
        return Ok(product);
    }

    [HttpPost]
    public void CreateProduct(ProductItem product)
    {
        _productsEntityService.Create(product);
    }
}