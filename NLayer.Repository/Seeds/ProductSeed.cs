using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new ProductFeature { Id = 1, ProductId = 1, Color = "red", Height = 200, Width = 200 },
                new ProductFeature { Id = 2, ProductId = 2, Color = "black", Height = 200, Width = 100 }
          );
        }
    }
}