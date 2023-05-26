namespace ClothesStore.Models.Models;

public record StockItem
{
    public Guid WarehouseId { get; init; }
    public Guid ProductItemId { get; init; }
    public int Amount { get; set; }
}