using EntityLayer;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);

        Cart GetCartByUserId(string userId);

        void AddToCart(string UserId, int productId, int Quantity);

        void DeleteFromCart(string UserId,int productId);
    }
}
