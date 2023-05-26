namespace ClothesStore.Models.Models;

public record ProductItem
{
    public Guid Id { get; init; }
    public string NomenclatureNumber { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public string? Description { get; set; }
}