using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class WarehouseEntityService : IEntityService<Warehouse>
{
    private readonly IDataStorage<Warehouse> _warehouse;

    public WarehouseEntityService(IDataStorage<Warehouse> warehouse)
    {
        _warehouse = warehouse;
    }

    public void Create(Warehouse obj)
    {
        _warehouse.Save(obj);
    }

    public IEnumerable<Warehouse> GetAll()
    {
        return _warehouse.FetchAll();
    }

    public Warehouse GetById(Guid id)
    {
        return _warehouse.Fetch(id);
    }
}