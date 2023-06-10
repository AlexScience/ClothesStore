using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class OrderDataStorage : FileDataStorage<Order>
{
    private const string Path = "order.txt";
    
    protected OrderDataStorage() : base(Path)
    {
        
    }
}