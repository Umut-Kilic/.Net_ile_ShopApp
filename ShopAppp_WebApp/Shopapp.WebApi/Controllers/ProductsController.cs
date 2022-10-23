using Business.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Shopapp.WebApi.Controllers
{
    //localhost/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products=await _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetById(id);
            if(product == null)
            {
                return NotFound();//404
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct),new {id=entity.ProductId} ,entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id,Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            var entity = await _productService.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _productService.UpdateAsync(product, entity);
            return NoContent();
        }
    }
}
