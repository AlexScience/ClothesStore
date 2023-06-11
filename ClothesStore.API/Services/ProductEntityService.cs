using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ProductEntityService : IEntityService<ProductItem>
{
    private readonly IDataStorage<ProductItem> _productItem;

    public ProductEntityService(IDataStorage<ProductItem> productItem)
    {
        _productItem = productItem;
    }


    public void Create(ProductItem obj)
    {
        _productItem.Save(obj);
    }

    public IEnumerable<ProductItem> GetAll()
    {
        return _productItem.FetchAll();
    }

    public ProductItem GetById(Guid id)
    {
        return _productItem.Fetch(id);
    }
}