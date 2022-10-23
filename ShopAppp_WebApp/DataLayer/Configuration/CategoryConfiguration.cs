using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(n => n.CategoryId);
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);


            builder.HasData(
                new Category() { CategoryId = 1, Name = "Telefon", Url = "telefon" },
                new Category() { CategoryId = 2, Name = "Bilgisayar", Url = "bilgisayar" },
                new Category() { CategoryId = 3, Name = "Elektronik", Url = "elektronik" },
                new Category() { CategoryId = 4, Name = "Beyaz Eşya", Url = "beyaz-esya" }
                
                );
        }
    }
}
