using Facpag.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facpag.Data.Mapping
{
    public class BillMap : IEntityTypeConfiguration<BillEntity>
    {
        public void Configure(EntityTypeBuilder<BillEntity> builder)
        {
            builder.ToTable("Bill");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Client)
                    .HasColumnName("Client")
                    .IsRequired()
                    .HasMaxLength(254);

            builder.Property(b => b.Telephone)
                    .HasColumnName("Telephone")
                    .HasMaxLength(12);

            builder.OwnsOne(b => b.Email)
                    .Property(b => b.Address)
                    .HasColumnName("Email");

            builder.Property(b => b.PaymentType)
                    .HasColumnName("PaymentType")
                    .IsRequired();
        }
    }
}
