using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(n => n.ProductId);
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);
          

            builder.HasData(
                new Product() { ProductId = 1, Name = "Samsung S5", Url = "samsung-s5", Price = 4500, ImageUrl = "1.jpg", Description = "İyi telefon", IsApproved = true },
                new Product() { ProductId = 2, Name = "Samsung S6", Url = "samsung-s6", Price = 6500, ImageUrl = "2.jpg", Description = "İyi telefon", IsApproved = false },
                new Product() { ProductId = 3, Name = "Samsung S7", Url = "samsung-s7", Price = 7500, ImageUrl = "3.jpg", Description = "İyi telefon", IsApproved = true },
                new Product() { ProductId = 4, Name = "Samsung S8", Url = "samsung-s8", Price = 8500, ImageUrl = "4.jpg", Description = "İyi telefon", IsApproved = false },
                new Product() { ProductId = 5, Name = "Samsung S10", Url = "samsung-s9", Price = 10500, ImageUrl = "5.jpg", Description = "İyi telefon", IsApproved = true }

                );
        }
    }
}
