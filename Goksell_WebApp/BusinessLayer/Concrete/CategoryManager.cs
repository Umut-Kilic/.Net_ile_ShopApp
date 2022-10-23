using BusinessLayer.Abstract;
using DataLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitofWork _unitofWork;
        public CategoryManager(IUnitofWork unitofWork)
        {
            _unitofWork= unitofWork;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Category entity)
        {
            _unitofWork.Categories.Create(entity);
            _unitofWork.Save();
        }

        public void Delete(Category entity)
        {
            _unitofWork.Categories.Delete(entity);
            _unitofWork.Save();
        }

        public List<Category> GetAll()
        {
            return _unitofWork.Categories.GetAll();
        }

        public Category GetById(int id)
        {
            return _unitofWork.Categories.GetById(id);
        }

        public Category GetByIdWithProducts(int id)
        {
            return _unitofWork.Categories.GetByIdWithProducts(id);
        }

        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            _unitofWork.Categories.Update(entity);
            _unitofWork.Save();
        }

        public bool Validation(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
