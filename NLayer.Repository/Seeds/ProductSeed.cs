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
                new Product { Id = 1, CategoryId = 1, Name = "Pencil-1", Price = 200, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Pencil-2", Price = 180, Stock = 25, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Name = "Pencil-3", Price = 160, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 1, Name = "Pencil-4", Price = 140, Stock = 35, CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 2, Name = "Book-1", Price = 120, Stock = 40, CreatedDate = DateTime.Now },
                new Product { Id = 6, CategoryId = 2, Name = "Book-2", Price = 699, Stock = 40, CreatedDate = DateTime.Now }
            );
        }
    }
}