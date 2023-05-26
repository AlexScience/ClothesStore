namespace ClothesStore.Models.Models;

public record OrderRow
{
    public Guid Id { get; init; }
    public Guid OrderId { get; init; }
    public Guid ProductItemId { get; init; }
    public int Amount { get; init; }
    public decimal Price { get; init; }
}