using TechTask.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechTask.Infrastructure.Mappings
{
    internal class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CustomerId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.OrderDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(c => c.Status)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(c => c.TotalCost)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Comment)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.HasMany(c => c.Products)
                .WithOne(b => b.Order)
                .HasForeignKey(b => b.OrderId);

            builder.ToTable("Orders");
        }
    }
}
