using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;

namespace NLayer.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Stock).IsRequired();
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.ToTable("Products");
            builder.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}