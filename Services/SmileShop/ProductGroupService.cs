using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SmileShop_API_V1.Data;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Models;
using SmileShop_API_V1.Models.SmileShop;
using System.Linq.Dynamic.Core;
using SmileShop_API_V1.Helpers;

namespace SmileShop_API_V1.Services.SmileShop
{
    public class ProductGroupService : ServiceBase, IProductGroupService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ProductGroupService(AppDBContext dbContext, IMapper mapper, IHttpContextAccessor httpContext)
        : base(dbContext, mapper, httpContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _httpContext = httpContext;
        }
        public async Task<ServiceResponse<GetProductGroupDto>> AddProductGroup(AddProductGroupDto newProductGroup)
        {
            try
            {
                var productGroups = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Name == newProductGroup.Name);
                if (!(productGroups is null))
                {
                    return ResponseResult.Failure<GetProductGroupDto>($"Product Name = {newProductGroup.Name} already exists.");
                }

                productGroups = _mapper.Map<ProductGroup>(newProductGroup);
                productGroups.CreatedById = Guid.Parse(GetUserId());
                _dbContext.ProductGroups.Add(productGroups);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductGroupDto>(productGroups);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductGroupDto>(ex.Message);
            }
        }

        public async Task<ServiceResponse<GetProductGroupDto>> DeleteProductGroup(int productGroupId)
        {
            try
            {
                var productGroups = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == productGroupId);
                if (productGroups is null)
                {
                    return ResponseResult.Failure<GetProductGroupDto>($"ProductGroup Id ({productGroupId}) not found.");
                }

                productGroups.IsActive = false;
                productGroups.UpdatedById = Guid.Parse(GetUserId());
                productGroups.UpdatedDate = Now();

                _dbContext.ProductGroups.Update(productGroups);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductGroupDto>(productGroups);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductGroupDto>(ex.Message);
            }
        }

        public async Task<ServiceResponse<List<GetProductGroupDto>>> GetProductGroupAll()
        {
            var productGroups = await _dbContext.ProductGroups.Include(x => x.CreatedBy).ToListAsync();
            var dto = _mapper.Map<List<GetProductGroupDto>>(productGroups);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponseWithPagination<List<GetProductGroupDto>>> GetProductGroupFilter(ProductGroupFilterDto filter)
        {
            var queryable = _dbContext.ProductGroups.Include(x => x.Products).Include(x => x.CreatedBy).AsQueryable();

            //Filter
            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
            }

            if (filter.IsActive != null)
            {
                queryable = queryable.Where(x => x.IsActive == filter.IsActive);
            }

            //Ordering
            if (!string.IsNullOrWhiteSpace(filter.OrderingField))
            {
                try
                {
                    queryable = queryable.OrderBy($"{filter.OrderingField} {(filter.AscendingOrder ? "ascending" : "descending")}");
                }
                catch
                {
                    return ResponseResultWithPagination.Failure<List<GetProductGroupDto>>($"Could not order by field: {filter.OrderingField}");
                }
            }

            var paginationResult = await _httpContext.HttpContext
                .InsertPaginationParametersInResponse(queryable, filter.RecordsPerPage, filter.Page);

            var productGroups = await queryable.Paginate(filter).ToListAsync();

            var dto = _mapper.Map<List<GetProductGroupDto>>(productGroups);

            return ResponseResultWithPagination.Success(dto, paginationResult);
        }

        public async Task<ServiceResponse<GetProductGroupDto>> GetProductGroupById(int productGroupId)
        {
            var productGroups = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == productGroupId);
            if (productGroups is null)
            {
                return ResponseResult.Failure<GetProductGroupDto>($"ProductGroup Id ({productGroupId}) not found.");
            }
            var dto = _mapper.Map<GetProductGroupDto>(productGroups);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<GetProductGroupDto>> UpdateProductGroup(int productGroupId, AddProductGroupDto newProductGroup)
        {
            try
            {
                var productGroups = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == productGroupId);
                if (productGroups is null)
                {
                    return ResponseResult.Failure<GetProductGroupDto>($"ProductGroup Id ({productGroupId}) not found.");
                }

                var duplicateName = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Name == newProductGroup.Name);
                if (!(duplicateName is null))
                {
                    return ResponseResult.Failure<GetProductGroupDto>($"Product Name = {newProductGroup.Name} already exists.");
                }

                var http = _httpContext.HttpContext.User;

                productGroups.Name = newProductGroup.Name;
                productGroups.UpdatedById = Guid.Parse(GetUserId());
                productGroups.UpdatedDate = Now();

                _dbContext.ProductGroups.Update(productGroups);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductGroupDto>(productGroups);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductGroupDto>(ex.Message);
            }
        }
    }
}