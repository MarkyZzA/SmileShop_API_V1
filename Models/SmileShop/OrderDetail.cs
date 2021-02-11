using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmileShop_API_V1.Models.SmileShop
{
    [Table("OrderDetail", Schema = "shop")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public Decimal Total { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public Decimal Discount { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public Decimal Net { get; set; }
    }
}