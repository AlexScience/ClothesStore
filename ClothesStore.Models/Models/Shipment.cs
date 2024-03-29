namespace ClothesStore.Models.Models;

public record Shipment
{
    public Guid Id { get; init; }
    public Guid WarehouseId { get; init; }
    public List<ShipmentItem> Items { get; init; }
}
