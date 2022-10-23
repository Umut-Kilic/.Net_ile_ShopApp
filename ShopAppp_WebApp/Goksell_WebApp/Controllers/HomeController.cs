using Business.Abstract;
using Goksell_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp_Goksel.WebUI.Controllers
{
    public class HomeController:Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }

        // locolhost :/home/index
        public IActionResult Index()
        {
            
            var productViewModel = new ProductListViewModel()
            {
                //Categories = categories,
                Products = _productService.GetHomePageProducts()
            };
            return View(productViewModel);

        }

        // locolhost :/home/about
        public IActionResult About()
        {
            return View();
        }
    }
}
