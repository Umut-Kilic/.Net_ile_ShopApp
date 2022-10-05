using DataLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Concrete
{
    public class ProductRepository : GenericRepository<Product, ShopContext>, IProductRepository
    {
        
        public int GetCountByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var products=context.Products.Where(p=>p.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                     products= products
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                     .Where(P => P.ProductCategories.Any(a => a.Category.Url == category));
                    return products.Count();
                }
                
                return context.Products.Count();
                
               
                
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.Where(p=>(p.IsHome && p.IsApproved)).ToList();
                
                return products;

            }
        }

      

        public List<Product> GetProductByCategoryName(string name,int page,int pageSize)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.Where(p=>p.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(p => p.ProductCategories)
                        .ThenInclude(pc => pc.Category)
                        .Where(P => P.ProductCategories.Any(a => a.Category.Url == name));

                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public Product GetProductByUrlName(string name)
        {
            using (var context = new ShopContext())
            {
                Product product=null ;
                if (!string.IsNullOrEmpty(name))
                {
                    product = context.Products
                        .Where(P => P.Url==name)
                        .Include(p=>p.ProductCategories)
                        .ThenInclude(pc=>pc.Category)
                        .FirstOrDefault();
                }
                return product;
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Where(p=>p.ProductId==id).Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).FirstOrDefault();
            }
        }

        public List<Product> GetProductsByProductName(string name)
        {
            using (var context = new ShopContext())
            {
                
                var products = context.Products
                    .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                    .ToList();

                return products;
            }
        }

       

        public List<Product> GetSearcResult(string searchString)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.
                    Where(p => p.IsApproved && (p.Name.ToLower().Contains(searchString.ToLower()) || p.Description.ToLower().Contains(searchString.ToLower()))).
                    AsQueryable();
                
                return products.ToList();
            }

        }

    
    }
}
