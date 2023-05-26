namespace ClothesStore.Models.Models;

public record PriceInfo
{
    public Guid ProductItemId { get; init; }
    public DateTime Date { get; init; }
    public decimal Price { get; init; }
}