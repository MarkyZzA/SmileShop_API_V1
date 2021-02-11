using SmileShop_API_V1.Validations;

namespace SmileShop_API_V1.DTOs
{
    public class RoleDtoAdd
    {
        [FirstLetterUpperCase]
        public string RoleName { get; set; }
    }
}