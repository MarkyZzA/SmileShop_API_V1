using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileShop_API_V1.Models.SmileShop
{
    [Table("Product", Schema = "shop")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductGroupId { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ProductGroup ProductGroup { get; set; }
        public bool IsActive { get; set; } = true;
        public ProductStatus ProductStatus { get; set; } = ProductStatus.Active;
        public List<OrderDetail> OrderDetails { get; set; }

        public Guid? UpdatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }

    }

    public enum ProductStatus
    {
        Active,
        Deleted
    }
}