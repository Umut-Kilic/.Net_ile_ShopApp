using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();

        }
        private static Category[] Categories =
        {
            new Category(){Name="Telefon",Url="telefon"},
            new Category(){Name="Bilgisayar",Url="bilgisayar"},
            new Category(){Name="Elektronik",Url="elektronik"},
            new Category(){Name="Beyaz Eşya",Url="beyaz-esya"}
        };
        private static Product[] Products =
        {
            new Product(){Name="Samsung S5",Url="samsung-s5",Price=4500,ImageUrl="1.jpg",Description="İyi telefon",IsApproved=true},
            new Product(){Name="Samsung S6",Url="samsung-s6",Price=6500,ImageUrl="2.jpg",Description="İyi telefon",IsApproved=false},
            new Product(){Name="Samsung S7",Url="samsung-s7",Price=7500,ImageUrl="3.jpg",Description="İyi telefon",IsApproved=true},
            new Product(){Name="Samsung S8",Url="samsung-s8",Price=8500,ImageUrl="4.jpg",Description="İyi telefon",IsApproved=false},
            new Product(){Name="Samsung S10",Url="samsung-s9",Price=10500,ImageUrl="5.jpg",Description="İyi telefon",IsApproved=true},

        };

        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
        };
    }
}
