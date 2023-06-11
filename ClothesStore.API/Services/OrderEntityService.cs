using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class OrderEntityService : IEntityService<Order>
{
    private readonly IDataStorage<Order> _orderStorage;

    public OrderEntityService(IDataStorage<Order> orderStorage)
    {
        _orderStorage = orderStorage;
    }

    public void Create(Order obj)
    {
        _orderStorage.Save(obj);
    }

    public IEnumerable<Order> GetAll()
    {
        return _orderStorage.FetchAll();
    }

    public Order GetById(Guid id)
    {
        return _orderStorage.Fetch(id);
    }
}