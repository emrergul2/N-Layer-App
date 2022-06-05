using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;

namespace NLayer.Repository.Configurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(pf => pf.Id);
            builder.Property(pf => pf.Id).IsRequired();
            builder.HasOne(p => p.Product).WithOne(pf => pf.ProductFeature).HasForeignKey<ProductFeature>(pf => pf.ProductId);
        }
    }
}