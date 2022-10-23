
using BusinessLayer.Abstract;
using EntityLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Task<Product> GetById(int id);
        Product GetByIdWithCategories(int id);
        Task<List<Product>> GetAll();
        bool Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        void Update(Product entity);
        Task UpdateAsync(Product entityToUpdate,Product entity);
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
