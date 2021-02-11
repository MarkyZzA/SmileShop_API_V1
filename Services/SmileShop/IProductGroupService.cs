using System.Collections.Generic;
using System.Threading.Tasks;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Models;

namespace SmileShop_API_V1.Services.SmileShop
{
    public interface IProductGroupService
    {
        Task<ServiceResponse<List<GetProductGroupDto>>> GetProductGroupAll();
        Task<ServiceResponse<GetProductGroupDto>> GetProductGroupById(int productGroupId);
        Task<ServiceResponse<GetProductGroupDto>> AddProductGroup(AddProductGroupDto newProductGroup);
        Task<ServiceResponse<GetProductGroupDto>> UpdateProductGroup(int productGroupId, AddProductGroupDto newProductGroup);
        Task<ServiceResponse<GetProductGroupDto>> DeleteProductGroup(int productGroupId);

        Task<ServiceResponseWithPagination<List<GetProductGroupDto>>> GetProductGroupFilter(ProductGroupFilterDto filter);


    }
}