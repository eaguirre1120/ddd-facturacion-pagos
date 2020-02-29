using Facpag.Domain.Entities;
using Facpag.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facpag.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(p => p.Id);

            builder.OwnsOne(p => p.Name)
                .Property(p => p.Value)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(ProductName.NameMaxLength);

            builder.OwnsOne(p => p.Price)
                .Property(p => p.Amount)
                .HasColumnName("Price")
                .IsRequired();

            builder.OwnsOne(p => p.Stock)
                .Property(p => p.Quantity)
                .HasColumnName("Stock")
                .IsRequired();
        }
    }
}
