using AutoMapper;
using SmileShop_API_V1.DTOs;
using SmileShop_API_V1.DTOs.SmileShop;
using SmileShop_API_V1.Models;
using SmileShop_API_V1.Models.SmileShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileShop_API_V1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>()
                .ForMember(x => x.RoleName, x => x.MapFrom(x => x.Name));
            CreateMap<RoleDtoAdd, Role>()
                .ForMember(x => x.Name, x => x.MapFrom(x => x.RoleName)); ;
            CreateMap<UserRole, UserRoleDto>();


            #region SmileShop
            CreateMap<ProductGroup, GetProductGroupDto>();
            CreateMap<Product, GetProductDto>();

            CreateMap<AddProductGroupDto, ProductGroup>();
            CreateMap<AddProductDto, Product>();
            CreateMap<User, GetCreatedByDto>();
            CreateMap<User, GetUpdatedByDto>();
            #endregion
        }
    }
}