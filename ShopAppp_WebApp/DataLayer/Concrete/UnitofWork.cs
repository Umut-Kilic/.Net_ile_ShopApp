using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ShopContext _context;

        public UnitofWork(ShopContext context)
        {
            _context = context;
            
        }

        private CartRepository _cartRepository;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private OrderRepository _orderRepository;


        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
        public ICartRepository Carts => _cartRepository = _cartRepository ?? new CartRepository(_context);
        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
