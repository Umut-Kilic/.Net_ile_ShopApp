using EntityLayer;
using System.Collections.Generic;

namespace Goksell_WebApp.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
