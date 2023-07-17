using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Request.Products
{
    public class UpdateProductInGroupRequest
    {
        public int? Priority { set; get; }
        public float? AdditionalPrice { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int? Quantity { set; get; }
        public ProductInGroupStatus? Status { set; get; }
    }
}
