using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetProductByCategoryName(string name, int page, int pageSize);
        Product GetProductDetails(int id);
        List<Product> GetSearcResult(string s);
        List<Product> GetHomePageProducts();
        Product GetProductByUrlName(string name);
        int GetCountByCategory(string category);

    }
}
