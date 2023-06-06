using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class ProductItemDataStorage : FileDataStorage<ProductItem>
{
    private const string Path = "product.txt";

    public ProductItemDataStorage() : base(Path)
    {
    }
}