using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL.FileStorage;

public class WarehouseDataStorage : FileDataStorage<Warehouse>
{
    private const string Path = "warehouse.txt";
    
    public WarehouseDataStorage() : base(Path)
    {
    }
}