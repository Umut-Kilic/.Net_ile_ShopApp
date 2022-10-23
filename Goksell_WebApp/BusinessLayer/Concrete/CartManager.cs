using BusinessLayer.Abstract;
using DataLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class CartManager : ICartService
    {
        private readonly IUnitofWork _unitofWork;

        public CartManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public void AddToCart(string UserId, int productId, int Quantity)
        {
            var cart=GetCartByUserId(UserId);
            if (cart != null)
            {
                //eklenmek isteyen urun var mı (guncelleme)

                //veya kayıt ekleme

                var index = cart.CartItems.FindIndex(i=>i.ProductId==productId);

                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity=Quantity,
                        CartId=cart.Id
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += Quantity;
                }

                _unitofWork.Carts.Update(cart);
                _unitofWork.Save();
                
            }
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetCartByUserId(userId);
            if (cart != null)
            {
                _unitofWork.Carts.DeleteFromCart(cart.Id, productId);
            }
        }

        public Cart GetCartByUserId(string userId)
        {
            return _unitofWork.Carts.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _unitofWork.Carts.Create(new Cart()
            {
                UserId = userId,
            });
            _unitofWork.Save();
        }
    }
}
