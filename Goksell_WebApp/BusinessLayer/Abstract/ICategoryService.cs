using EntityLayer;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IValidator<Category>  
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        List<Category> GetPopularCategories();
        Category GetByIdWithProducts(int id);
    }
}
