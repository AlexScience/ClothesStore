using ClothesStore.API.DAL.Configurations;
using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothesStore.API.DAL;

public class StoreDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!;
    public DbSet<ProductItem> ProductItems { get; set; } = default!;


    public StoreDbContext(DbContextOptions<StoreDbContext> options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ClientsConfiguration());
        modelBuilder.ApplyConfiguration(new ProductItemsConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Server=localhost;Port=54320;Database=postgres;User Id=postgres;Password=my_password");
    }
}