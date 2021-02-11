using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Services.SmileShop;

namespace SmileShop_API_V1.Controllers.SmileShop
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetProductAll());
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetFilter([FromQuery] ProductFilterDto filter)
        {
            return Ok(await _service.GetProductFilter(filter));
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            return Ok(await _service.GetProductById(productId));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDto newProduct)
        {
            return Ok(await _service.AddProduct(newProduct));
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct(int productId, AddProductDto newProduct)
        {
            return Ok(await _service.UpdateProduct(productId, newProduct));
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            return Ok(await _service.DeleteProduct(productId));
        }
    }
}