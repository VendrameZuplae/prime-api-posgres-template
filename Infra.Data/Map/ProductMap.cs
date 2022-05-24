using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("bigint");
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("text");
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("text");
            builder.Property(x => x.Price).HasColumnName("Price").HasColumnType("numeric");
        }
    }
}
