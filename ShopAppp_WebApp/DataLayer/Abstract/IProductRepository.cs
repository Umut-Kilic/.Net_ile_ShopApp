
using EntityLayer;
using System.Collections.Generic;

namespace DataLayer.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetProductByCategoryName(string name, int page, int pageSize);
        Product GetProductDetails(int id);
        List<Product> GetSearcResult(string s);
        List<Product> GetHomePageProducts();
        Product GetProductByUrlName(string name);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
        void Update(Product product, int[] categoryIds);
    }
}
