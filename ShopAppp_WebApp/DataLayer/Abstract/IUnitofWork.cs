using DataLayer.Concrete;
using System;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IUnitofWork:IDisposable
    {
        
        IProductRepository Products { get;}
        ICartRepository Carts { get; }
        IOrderRepository Orders { get;  }
        ICategoryRepository Categories { get;  }
        void Save();
        Task<int> SaveAsync();
    }
}
