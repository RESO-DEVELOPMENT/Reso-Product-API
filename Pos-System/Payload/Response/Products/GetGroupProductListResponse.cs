using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Products
{
    public class GetGroupProductListResponse
    {
        public Guid Id { get; set; }
        public Guid ComboProductId { get; set; }
        public string Name { get; set; }
        public GroupCombinationMode CombinationMode { get; set; }
        public int Priority { get; set; }
        public int Quantity { get; set; }
        public GroupProductStatus Status { get; set; }
        public List<ProductsInGroupResponse> ProductsInGroups { get; set; }
    }

    public class ProductsInGroupResponse
    {
        public Guid Id { get; set; }
        public Guid GroupProductId { get; set; }
        public Guid ProductId { get; set; }
        public int Priority { get; set; }
        public double AdditionalPrice { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public ProductInGroupStatus Status { get; set; }
    }
}
