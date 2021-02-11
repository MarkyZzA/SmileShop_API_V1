using System.ComponentModel.DataAnnotations;
using SmileShop_API_V1.Validations;

namespace SmileShop_API_V1.DTOs.SmileShop
{
    public class AddProductDto
    {
        [Required]
        [StringLength(20)]
        [FirstLetterUpperCaseAttribute]
        public string Name { get; set; }
        [Required]
        public int ProductGroupId { get; set; }
        [Required]
        [Range(0, 999999)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 999)]
        public int Stock { get; set; }
    }
}