using BusinessLayer.Abstract;
using DataLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Category> CreateAsync(Category entity)
        {
            await _unitofWork.Categories.CreateAsync(entity);
            await _unitofWork.SaveAsync();
            return entity;
        }

        public void Delete(Category entity)
        {
            _unitofWork.Categories.Delete(entity);
            _unitofWork.Save();
        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitofWork.Categories.GetAll();
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitofWork.Categories.GetById(id);
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
