using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ProductServices : IProductsService
{
    private readonly IDataStorage<ProductItem> _productStorage; 
    
    public  ProductServices(IDataStorage<ProductItem> productItem)
    {
        _productStorage = productItem;
    }

    public void CreateProduct(ProductItem productItem)
    {
        _productStorage.Save(productItem);
    }

    public IEnumerable<ProductItem> GetAllProductItem()
    {
        return _productStorage.FetchAll();
    }

    public ProductItem GetProductItemId(Guid productItemId)
    {
        return _productStorage.Fetch(productItemId);
    }
}