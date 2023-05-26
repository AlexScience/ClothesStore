namespace ClothesStore.Models.Models;

public record ShipmentItem
{
    public Guid Id { get; init; }
    public Guid ShipmentId { get; init; }
    public Guid ProductItemId { get; init; }
    public int Amount { get; init; }
    public decimal Price { get; init; }
}