namespace ClothesStore.UI.Models;

public class ProductItemDraft
{
    public Guid Id { get; set; }
    public string NomenclatureNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? Description { get; set; }
}