using DataLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(ShopContext context):base(context) 
        {

        }

        private ShopContext ShopContext
        {

            get { return context as ShopContext; }
        }
        public Product GetByIdWithCategories(int id)
        {
            
                var products = ShopContext.Products.Where(i => i.ProductId==id).Include(i=>i.ProductCategories).ThenInclude(pc=>pc.Category).FirstOrDefault();
                return products;
            
        }

        public int GetCountByCategory(string category)
        {
            
                var products=ShopContext.Products.Where(p=>p.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                     products= products
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                     .Where(P => P.ProductCategories.Any(a => a.Category.Url == category));
                    return products.Count();
                }
                
                return ShopContext.Products.Count();
            
        }

        public List<Product> GetHomePageProducts()
        {
            
                var products = ShopContext.Products.Where(p=>(p.IsHome && p.IsApproved)).ToList();
                
                return products;

        }

      

        public List<Product> GetProductByCategoryName(string name,int page,int pageSize)
        {
            
                var products = ShopContext.Products.Where(p=>p.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(p => p.ProductCategories)
                        .ThenInclude(pc => pc.Category)
                        .Where(P => P.ProductCategories.Any(a => a.Category.Url == name));

                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            
        }

        public Product GetProductByUrlName(string name)
        {
           
                Product product=null ;
                if (!string.IsNullOrEmpty(name))
                {
                    product = ShopContext.Products
                        .Where(P => P.Url==name)
                        .Include(p=>p.ProductCategories)
                        .ThenInclude(pc=>pc.Category)
                        .FirstOrDefault();
                }
                return product;
            
        }

        public Product GetProductDetails(int id)
        {
          
                return ShopContext.Products.Where(p=>p.ProductId==id).Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).FirstOrDefault();
            
        }

        public List<Product> GetProductsByProductName(string name)
        {
          
                var products = ShopContext.Products
                    .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                    .ToList();

                return products;
            
        }

       

        public List<Product> GetSearcResult(string searchString)
        {
            
                var products = ShopContext.Products.
                    Where(p => p.IsApproved && (p.Name.ToLower().Contains(searchString.ToLower()) || p.Description.ToLower().Contains(searchString.ToLower()))).
                    AsQueryable();
                
                return products.ToList();
            

        }

        public void Update(Product entity, int[] categoryIds)
        {
            
                var product = ShopContext.Products.Include(p=>p.ProductCategories).FirstOrDefault(i => i.ProductId == entity.ProductId);
                if (product != null)
                {
                    product.Price = entity.Price;
                    product.Name = entity.Name;
                    product.Description = entity.Description;
                    product.Url = entity.Url;
                    product.ImageUrl = entity.ImageUrl;
                    product.IsApproved = entity.IsApproved;
                    product.IsHome = entity.IsHome;

                    product.ProductCategories = categoryIds.Select(cId => new ProductCategory()
                    {
                        ProductId= product.ProductId,
                        CategoryId= cId,
                    }).ToList();

                }
        }
    }
}
