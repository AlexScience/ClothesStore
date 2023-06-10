using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class ShipmentDataStorage : FileDataStorage<Shipment>
{
    private const string Path = "shipment.txt";
    
    protected ShipmentDataStorage() : base(Path)
    {
    }
}