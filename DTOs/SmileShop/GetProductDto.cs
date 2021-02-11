using System;

namespace SmileShop_API_V1.DTOs.SmileShop
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductGroupId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public string CreatedById { get; set; }
        public GetCreatedByDto CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public GetProductGroupDto ProductGroup { get; set; }
    }
}