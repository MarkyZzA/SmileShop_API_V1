using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SmileShop_API_V1.Data;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Helpers;
using SmileShop_API_V1.Models;
using SmileShop_API_V1.Models.SmileShop;
using System.Linq.Dynamic.Core;

namespace SmileShop_API_V1.Services.SmileShop
{
    public class ProductService : ServiceBase, IProductService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ProductService(AppDBContext dbContext, IMapper mapper, IHttpContextAccessor httpContext)
        : base(dbContext, mapper, httpContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _httpContext = httpContext;
        }
        public async Task<ServiceResponse<GetProductDto>> AddProduct(AddProductDto newProduct)
        {
            try
            {
                var product = await _dbContext.Products.Include(x => x.ProductGroup).FirstOrDefaultAsync(x => x.Name == newProduct.Name);
                if (!(product is null))
                {
                    return ResponseResult.Failure<GetProductDto>($"Product Name = {newProduct.Name} already exists.");
                }

                var productGroup = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == newProduct.ProductGroupId);
                if (productGroup is null)
                {
                    return ResponseResult.Failure<GetProductDto>($"ProductGroup Id = {newProduct.ProductGroupId} not found.");
                }

                product = _mapper.Map<Product>(newProduct);
                product.CreatedById = Guid.Parse(GetUserId());
                product.ProductGroup = productGroup;

                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductDto>(product);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductDto>(ex.Message);
            }
        }

        public async Task<ServiceResponse<GetProductDto>> DeleteProduct(int productId)
        {
            try
            {
                var product = await _dbContext.Products.Include(x => x.ProductGroup)
                .FirstOrDefaultAsync(x => x.Id == productId);
                if (product is null)
                {
                    return ResponseResult.Failure<GetProductDto>($"Product Id ({productId}) not found.");
                }

                product.IsActive = false;
                product.UpdatedById = Guid.Parse(GetUserId());
                product.UpdatedDate = Now();

                _dbContext.Products.Update(product);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductDto>(product);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductDto>(ex.Message);
            }
        }

        public async Task<ServiceResponse<List<GetProductDto>>> GetProductAll()
        {
            var products = await _dbContext.Products.Include(x => x.ProductGroup).Include(x => x.CreatedBy).AsNoTracking().ToListAsync();
            var dto = _mapper.Map<List<GetProductDto>>(products);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<GetProductDto>> GetProductById(int ProductId)
        {
            var product = await _dbContext.Products.Include(x => x.ProductGroup).Include(x => x.CreatedBy).FirstOrDefaultAsync(x => x.Id == ProductId);
            if (product is null)
            {
                return ResponseResult.Failure<GetProductDto>($"Product Id ({ProductId}) not found.");
            }
            var dto = _mapper.Map<GetProductDto>(product);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponseWithPagination<List<GetProductDto>>> GetProductFilter(ProductFilterDto filter)
        {
            var queryable = _dbContext.Products.Include(x => x.ProductGroup).Include(x => x.CreatedBy).AsQueryable();

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
                    return ResponseResultWithPagination.Failure<List<GetProductDto>>($"Could not order by field: {filter.OrderingField}");
                }
            }

            var paginationResult = await _httpContext.HttpContext
                .InsertPaginationParametersInResponse(queryable, filter.RecordsPerPage, filter.Page);

            var productGroups = await queryable.Paginate(filter).ToListAsync();

            var dto = _mapper.Map<List<GetProductDto>>(productGroups);

            return ResponseResultWithPagination.Success(dto, paginationResult);
        }

        public async Task<ServiceResponse<GetProductDto>> UpdateProduct(int productId, AddProductDto newProduct)
        {
            try
            {
                var products = await _dbContext.Products.Include(x => x.ProductGroup).FirstOrDefaultAsync(x => x.Id == productId);
                if (products is null)
                {
                    return ResponseResult.Failure<GetProductDto>($"Product Id ({productId}) not found.");
                }

                products.Name = newProduct.Name;
                products.Price = newProduct.Price;
                products.ProductGroupId = newProduct.ProductGroupId;
                products.Stock = newProduct.Stock;
                products.UpdatedById = Guid.Parse(GetUserId());
                products.UpdatedDate = Now();

                _dbContext.Products.Update(products);
                await _dbContext.SaveChangesAsync();

                var dto = _mapper.Map<GetProductDto>(products);
                return ResponseResult.Success(dto);
            }
            catch (Exception ex)
            {
                return ResponseResult.Failure<GetProductDto>(ex.Message);
            }
        }
    }
}