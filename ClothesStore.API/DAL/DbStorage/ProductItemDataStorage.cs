using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL.DbStorage;

public class ProductItemDataStorage : IDataStorage<ProductItem>
{
    private readonly StoreDbContext _context;

    public ProductItemDataStorage(StoreDbContext context)
    {
        _context = context;
    }

    public void Save(ProductItem obj)
    {
        _context.ProductItems.Add(obj);
        _context.SaveChanges();
    }

    public ProductItem? Fetch(Guid id)
    {
        return _context.ProductItems.FirstOrDefault(c => c.Id.Equals(id));
    }

    public IEnumerable<ProductItem> FetchAll()
    {
        return _context.ProductItems.ToList();
    }
}

