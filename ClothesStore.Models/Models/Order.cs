namespace ClothesStore.Models.Models;

public record Order : IEntity
{
    public Guid Id { get; init; }
    public Guid ClientId { get; init; }
    public string DeliveryAddress { get; set; } = string.Empty;
    public List<OrderRow> Items { get; init; } = new();
}