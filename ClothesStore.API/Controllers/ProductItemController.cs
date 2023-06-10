using ClothesStore.API.Services;
using ClothesStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductItemController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductItemController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<ProductItem>> GetAllProductItem()
    {
        var product = _productsService.GetAllProductItem();
        return Ok(product);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<ProductItem>> GetProductById(Guid porductId)
    {
        ProductItem product = _productsService.GetProductItemId(porductId);
        return Ok(product);
    }

    [HttpPost]
    public void Create(ProductItem product)
    {
        _productsService.CreateProduct(product);
    }
}