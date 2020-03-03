using Facpag.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facpag.Data.Mapping
{
    public class DetailMap : IEntityTypeConfiguration<DetailEntity>
    {
        public void Configure(EntityTypeBuilder<DetailEntity> builder)
        {
            builder.ToTable("Detail");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.BillId)
                   .HasColumnName("Billid")
                   .IsRequired();
            builder.Property(d => d.ProductId)
                   .HasColumnName("ProductId")
                   .IsRequired();
            builder.OwnsOne(d => d.ProductName)
                    .Property(d => d.Value)
                    .HasColumnName("ProductName")
                    .IsRequired();
            builder.Property(d => d.Quantity)
                    .HasColumnName("Quantity")
                    .IsRequired();
            builder.OwnsOne(d => d.Price)
                    .Property(d => d.Amount)
                    .HasColumnName("Price")
                    .IsRequired();
        }
    }
}
