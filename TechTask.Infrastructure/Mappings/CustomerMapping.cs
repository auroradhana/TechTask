using TechTask.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechTask.Infrastructure.Mappings
{
    internal class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Adress)
                .HasColumnType("varchar(150)");

            builder.Property(c => c.TotalOrdered)
                .IsRequired()
                .HasDefaultValue(0)
                .HasColumnType("int");

            builder.Property(c => c.OrdersCount)
                .IsRequired()
                .HasDefaultValue(0)
                .HasColumnType("int");


            builder.HasMany(c => c.Orders)
                .WithOne(b => b.Customer)
                .HasForeignKey(b => b.CustomerId);

            builder.ToTable("Customers");
        }
    }
}
