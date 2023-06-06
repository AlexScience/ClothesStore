namespace ClothesStore.Models.Models;

public record Warehouse : IEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}