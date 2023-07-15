using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStore.API.DAL.Configurations;

public class ProductItemConfiguration: IEntityTypeConfiguration<ProductItem>
{

    public void Configure(EntityTypeBuilder<ProductItem> builder)
    {
        builder.ToTable("productItem");

        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.NomenclatureNumber)
            .HasColumnName("NomenclatureNumber")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.Category)
            .HasColumnName("Category")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(c => c.Description)
            .HasColumnName("Description")
            .HasColumnType("varchar")
            .HasMaxLength(300)
            .IsRequired();
    }
}
