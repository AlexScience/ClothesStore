using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothesStore.API.DAL;

public class StoreDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!;
}