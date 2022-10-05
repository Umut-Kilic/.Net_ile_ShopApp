using EntityLayer;
using System.Collections.Generic;

namespace DataLayer.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
