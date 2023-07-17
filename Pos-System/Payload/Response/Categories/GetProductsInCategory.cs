using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Categories
{
    public class GetProductsInCategory
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? PicUrl { get; set; }
        public double? SellingPrice { get; set; }
        public double DiscountPrice { get; set; }
        public double HistoricalPrice { get; set; }
        public ProductStatus Status { get; set; }
        public ProductType Type { get; set; }
    }
}
