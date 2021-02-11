using System.Collections.Generic;
using System.Threading.Tasks;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Models;

namespace SmileShop_API_V1.Services.SmileShop
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetProductAll();
        Task<ServiceResponse<GetProductDto>> GetProductById(int ProductDtoId);
        Task<ServiceResponse<GetProductDto>> AddProduct(AddProductDto newProductDto);
        Task<ServiceResponse<GetProductDto>> UpdateProduct(int ProductDtoId, AddProductDto newProductDto);
        Task<ServiceResponse<GetProductDto>> DeleteProduct(int ProductDtoId);
        Task<ServiceResponseWithPagination<List<GetProductDto>>> GetProductFilter(ProductFilterDto filter);
    }
}