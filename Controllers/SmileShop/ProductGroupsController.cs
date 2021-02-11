using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Services.SmileShop;

namespace SmileShop_API_V1.Controllers.SmileShop
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductGroupsController : ControllerBase
    {
        private readonly IProductGroupService _service;

        public ProductGroupsController(IProductGroupService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetProductGroupAll());
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetFilter([FromQuery] ProductGroupFilterDto filter)
        {
            return Ok(await _service.GetProductGroupFilter(filter));
        }

        [HttpGet("{productGroupId}")]
        public async Task<IActionResult> GetById(int productGroupId)
        {
            return Ok(await _service.GetProductGroupById(productGroupId));
        }

        [HttpPost]
        public async Task<IActionResult> AddProductGroup(AddProductGroupDto newProductGroup)
        {
            return Ok(await _service.AddProductGroup(newProductGroup));
        }

        [HttpPut("{productGroupId}")]
        public async Task<IActionResult> UpdateProductGroup(int productGroupId, AddProductGroupDto newProductGroup)
        {
            return Ok(await _service.UpdateProductGroup(productGroupId, newProductGroup));
        }

        [HttpDelete("{productGroupId}")]
        public async Task<IActionResult> DeleteProductGroup(int productGroupId)
        {
            return Ok(await _service.DeleteProductGroup(productGroupId));
        }
    }
}