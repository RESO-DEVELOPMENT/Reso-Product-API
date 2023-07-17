using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Request.Products
{
    public class UpdateGroupProductRequest
    {
        public Guid? ComboProductId { get; set; }
        public string Name { get; set; }
        public GroupCombinationMode CombinationMode { get; set; }
        public int Priority { get; set; }
        public int Quantity { get; set; }
        public List<ProductInGroupRequest>? Products { get; set; }
    }

    public class ProductInGroupRequest
    {
        public Guid Id { get; set; }
        public int? Priority { set; get; }
        public float? AdditionalPrice { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int? Quantity { set; get; }
    }
}
