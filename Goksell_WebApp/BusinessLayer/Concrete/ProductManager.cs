using Business.Abstract;
using DataLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        
        private  IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            //iş kuralları
            if (entity.Name.Contains("a"))
            {
                _productRepository.Create(entity);

            }
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return _productRepository.GetHomePageProducts();
        }

        public List<Product> GetProductByCategoryName(string name, int page, int pageSize)
        {
            return _productRepository.GetProductByCategoryName(name,page,pageSize);
        }

        public Product GetProductByUrlName(string name)
        {
            return _productRepository.GetProductByUrlName(name);
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }

       

        public List<Product> GetSearcResult(string s)
        {
            return _productRepository.GetSearcResult(s);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
