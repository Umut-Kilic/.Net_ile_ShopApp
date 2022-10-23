using System.Collections.Generic;
using System.Linq;

namespace Goksell_WebApp.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> CartItems { get; set; }
        public double CartTotal()
        {
            return CartItems.Sum(i => i.Price * i.Quantity);
        }
        public double TotalPrice()
        {
            var price = CartItems.Sum(i => i.Price * i.Quantity);
            return  price>=100? price:price+19.99;
        }
        public bool ShippingPrice()
        {
            return this.TotalPrice() >= 100 ? true : false;
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }

}
