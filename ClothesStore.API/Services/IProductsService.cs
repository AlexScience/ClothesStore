using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public interface IProductsService
{
    public void CreateProduct(ProductItem productItem);
    public IEnumerable<ProductItem> GetAllProductItem();
    public ProductItem GetProductItemId(Guid productItemId);
    
}