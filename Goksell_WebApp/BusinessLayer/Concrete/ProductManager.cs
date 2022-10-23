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

        private readonly IUnitofWork _unitofWork;
        public ProductManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public bool Create(Product entity)
        {
            //iş kuralları

            if (Validation(entity))
            {
                _unitofWork.Products.Create(entity);
                _unitofWork.Save();
                return true;
            }

            return false;


        }

        public void Delete(Product entity)
        {
            _unitofWork.Products.Delete(entity);
            _unitofWork.Save();
        }

        public List<Product> GetAll()
        {
            return _unitofWork.Products.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitofWork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitofWork.Products.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _unitofWork.Products.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return _unitofWork.Products.GetHomePageProducts();
        }

        public List<Product> GetProductByCategoryName(string name, int page, int pageSize)
        {
            return _unitofWork.Products.GetProductByCategoryName(name,page,pageSize);
        }

        public Product GetProductByUrlName(string name)
        {
            return _unitofWork.Products.GetProductByUrlName(name);
        }

        public Product GetProductDetails(int id)
        {
            return _unitofWork.Products.GetProductDetails(id);
        }

       

        public List<Product> GetSearcResult(string s)
        {
            return _unitofWork.Products.GetSearcResult(s);
        }

        public void Update(Product entity)
        {
            _unitofWork.Products.Update(entity);
            _unitofWork.Save();
        }

        public bool Update(Product product, int[] categoryIds)
        {
            if (Validation(product))
            {
                if (categoryIds.Length == 0)
                {
                    ErrorMessage += "Ürün için en az 1 kategori seçmelisiniz";
                    return false;
                }
                _unitofWork.Products.Update(product);
                _unitofWork.Save();
                return true;
            }

            return false;

        }


        public string ErrorMessage { get ; set ; }

        public bool Validation(Product entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Ürün ismi girmelisiniz.\n";
                isValid = false;
            }
            if (entity.Price<0)
            {
                ErrorMessage += "Ürün fiyatı negatif olamaz.\n";
                isValid = false;
            }

            return isValid;
        }
    }
}
