using System;

namespace SmileShop_API_V1.DTOs.SmileShop
{
    public class ProductFilterDto : PaginationDto
    {
        //Filter
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        //Ordering
        public string OrderingField { get; set; }
        public bool AscendingOrder { get; set; } = true;
    }
}