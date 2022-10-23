using Business.Abstract;
using Goksell_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Goksell_WebApp.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;  
        }

        public IActionResult List(string category,int page=1)
        {
            const int pageSize = 2;

            ProductListViewModel productListViewModel = new ProductListViewModel()
            {
                PageInfo= new PageInfo()
                {
                    CurrentPage=page,
                    ItemsPerPage=pageSize,
                    TotalItems=_productService.GetCountByCategory(category),
                    CurrentCategory=category,
                },
                Products=_productService.GetProductByCategoryName(category,page,pageSize)
            };
            return View(productListViewModel);
            
            
        }
        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            var product = _productService.GetProductByUrlName(url);
            if (product == null)
            {
                return NotFound();
            }
            var productDetailModel = new ProductDetailModel() { 
                Product = product, 
                Categories = product.ProductCategories.Select(pc => pc.Category).ToList()
            };
            return View(productDetailModel);


        }
        public IActionResult Search(string q)
        {

            var product = new ProductListViewModel();
          
            var productListModel = new ProductListViewModel()
            {
                Products = _productService.GetSearcResult(q)
               
            };
            return View(productListModel);
        }
    }
}
