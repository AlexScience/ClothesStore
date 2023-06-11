using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class OrderDataStorage : FileDataStorage<Order>
{
    private const string Path = "order.txt";
    
    public OrderDataStorage() : base(Path)
    {
        
    }
}