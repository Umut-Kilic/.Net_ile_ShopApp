using DataLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContext context):base(context)    
        {

        }
        private ShopContext ShopContext { get {return context as ShopContext; }  }
        public Category GetByIdWithProducts(int id)
        {
            
                var category = ShopContext.Categories.Include(c => c.ProductCategories).FirstOrDefault(c => c.CategoryId == id);
                return category;

        }

        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
