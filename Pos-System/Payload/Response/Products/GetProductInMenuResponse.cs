using Pos_System.API.Enums;
using Pos_System.API.Utils;

namespace Pos_System.API.Payload.Response.Products
{
    public class GetProductInMenuResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double SellingPrice { get; set; }
        public string? PicUrl { get; set; }
        public double HistoricalPrice { get; set; }
        public double DiscountPrice { get; set; }
        public ProductType Type { get; set; }
        public GetProductInMenuResponse(Guid id, string name, string code, string? picUrl, double sellingPrice, double historicalPrice, double discountPrice, string type)
        {
            Id = id;
            Name = name;
            Code = code;
            PicUrl = picUrl;
            SellingPrice = sellingPrice;
            HistoricalPrice = historicalPrice;
            DiscountPrice = discountPrice;
            Type = EnumUtil.ParseEnum<ProductType>(type);
        }
    }
}
