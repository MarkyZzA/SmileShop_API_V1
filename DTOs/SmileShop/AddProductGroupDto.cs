using System.ComponentModel.DataAnnotations;
using SmileShop_API_V1.Validations;

namespace SmileShop_API_V1.DTOs.SmileShop
{
    public class AddProductGroupDto
    {
        [Required]
        [StringLength(20)]
        [FirstLetterUpperCaseAttribute]
        public string Name { get; set; }
    }
}