namespace ClothesStore.Models.Models;

public record Client
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string DeliveryAddress { get; set; } = string.Empty;
}