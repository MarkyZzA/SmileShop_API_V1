using System;
using System.Collections.Generic;

namespace SmileShop_API_V1.DTOs.SmileShop
{
    public class GetProductGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CreatedById { get; set; }

        public GetCreatedByDto CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public List<GetProductDto> Products { get; set; }
    }
}