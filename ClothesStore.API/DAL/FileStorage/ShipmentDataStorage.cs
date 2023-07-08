using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL.FileStorage;

public class ShipmentDataStorage : FileDataStorage<Shipment>
{
    private const string Path = "shipment.txt";
    
    public ShipmentDataStorage() : base(Path)
    {
    }
}