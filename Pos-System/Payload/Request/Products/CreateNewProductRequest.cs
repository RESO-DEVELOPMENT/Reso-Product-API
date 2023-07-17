using System.ComponentModel.DataAnnotations;
using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Request.Products
{
    public class CreateNewProductRequest
    {
        [MaxLength(50, ErrorMessage = "Tên của product phải dưới 50 kí tự")]
        public string Name { get; set; }
        [MaxLength(20, ErrorMessage = "Code của product phải dưới 20 kí tự")]
        public string Code { get; set; }
        [Required]
        public double SellingPrice { get; set; }
        public string? PicUrl { get; set; }
        [Required]
        public string CategoryId { get; set; }
        [Required]
        public double HistoricalPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public string? Description { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        public ProductSize? Size { get; set; }
        [Required]
        public ProductType Type { get; set; }
        public string? ParentProductId { get; set; }
    }
}

