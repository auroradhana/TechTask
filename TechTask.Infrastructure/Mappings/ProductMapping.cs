using TechTask.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechTask.Infrastructure.Mappings
{
    internal class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.OrderId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Category)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Quantity)
                .IsRequired()
                .HasDefaultValue(1)
                .HasColumnType("int");

            builder.Property(c => c.Price)
                .IsRequired()
                .HasDefaultValue(1)
                .HasColumnType("int");

            builder.Property(c => c.OrderId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Description)
                .HasColumnType("varchar(150)");

            builder.Property(c => c.CreatedDate)
                .IsRequired()
                .HasColumnType("date");

            builder.ToTable("Products");
        }
    }
}
