﻿using DataLayer.Configuration;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Concrete
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {

        }
       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"server=(localdb)\MSSQLLocalDB;Database=GokselWebDb;";

            optionsBuilder.UseSqlServer(connectionString);
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
        }
    }
}