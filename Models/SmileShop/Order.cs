using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileShop_API_V1.Models.SmileShop
{
    [Table("Order", Schema = "shop")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ItemCount { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public Decimal Total { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public Decimal Discount { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public Decimal Net { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<OrderDetail> OrderDetails { get; set; }

        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}