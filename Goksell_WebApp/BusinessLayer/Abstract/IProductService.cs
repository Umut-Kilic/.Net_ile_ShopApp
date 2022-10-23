
using BusinessLayer.Abstract;
using EntityLayer;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        List<Product> GetAll();
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetProductByCategoryName(string name, int page, int pageSize);
        Product GetProductDetails(int id);
        List<Product> GetSearcResult(string s);
        List<Product> GetHomePageProducts();
        Product GetProductByUrlName(string name);
        int GetCountByCategory(string category);
        bool Update(Product product, int[] categoryIds);
    }
}
