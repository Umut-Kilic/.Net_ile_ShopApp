using DataLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(ShopContext context):base(context)    
        {

        }

        private ShopContext ShopContext {

            get { return context as ShopContext; }
        }
        public void DeleteFromCart(int cartId, int productId)
        {
            
                var command = @"Delete From CartItems Where CartId=@p0 and ProductId=@p1";
                ShopContext.Database.ExecuteSqlRaw(command, cartId, productId);

            

        }
        public Cart GetByUserId(string userId)
        {
            
                return ShopContext.Carts.Include(i => i.CartItems).ThenInclude(c=>c.Product).FirstOrDefault(i=>i.UserId==userId);
            
        }

        public override void Update(Cart entity)
        {
          
            ShopContext.Carts.Update(entity);
     
        }
    }
}
