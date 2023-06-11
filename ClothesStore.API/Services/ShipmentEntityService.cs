using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ShipmentEntityService : IEntityService<Shipment>
{
    private readonly IDataStorage<Shipment> _shipment;

    public ShipmentEntityService(IDataStorage<Shipment> shipment)
    {
        _shipment = shipment;
    }

    public void Create(Shipment obj)
    {
        _shipment.Save(obj);
    }

    public IEnumerable<Shipment> GetAll()
    {
        return _shipment.FetchAll();
    }

    public Shipment GetById(Guid id)
    {
        return _shipment.Fetch(id);
    }
}