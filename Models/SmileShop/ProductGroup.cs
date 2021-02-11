using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileShop_API_V1.Models.SmileShop
{
    [Table("ProductGroup", Schema = "shop")]
    public class ProductGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public List<Product> Products { get; set; }
        public bool IsActive { get; set; } = true;
        public ProductGroupStatus ProductGroupStatus { get; set; } = ProductGroupStatus.Active;

        public Guid? UpdatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
    }

    public enum ProductGroupStatus
    {
        Active,
        Deleted
    }
}