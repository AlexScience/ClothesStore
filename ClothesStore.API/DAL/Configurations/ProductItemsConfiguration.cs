using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStore.API.DAL.Configurations;

public class ProductItemsConfiguration: IEntityTypeConfiguration<ProductItem>
{

    public void Configure(EntityTypeBuilder<ProductItem> builder)
    {
        builder.ToTable("product_items");

        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.NomenclatureNumber)
            .HasColumnName("nomenclature_number")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.Name)
            .HasColumnName("name")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.Category)
            .HasColumnName("category")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(c => c.Description)
            .HasColumnName("description")
            .HasColumnType("varchar")
            .HasMaxLength(300)
            .IsRequired();
    }
}
