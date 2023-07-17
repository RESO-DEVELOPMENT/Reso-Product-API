using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Orders
{
    public class GetOrderDetailResponse
    {
        public Guid OrderId { get; set; }
        public string InvoiceId { get; set; }
        public double TotalAmount { get; set; }
        public double FinalAmount { get; set; }
        public double Vat { get; set; }
        public double VatAmount { get; set; }
        public double Discount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderType OrderType { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public DateTime CheckInDate { get; set; }
        public string? DiscountName { get; set; }
        public List<OrderProductDetailResponse> ProductList { get; set; } = new List<OrderProductDetailResponse>();
    }

    public class OrderProductDetailResponse
    {
        public Guid ProductInMenuId { get; set; }
        public Guid OrderDetailId { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double TotalAmount { get; set; }
        public double FinalAmount { get; set; }
        public double Discount { get; set; }
        public string Note { get; set; }
        public List<OrderProductExtraDetailResponse> Extras { get; set; } = new List<OrderProductExtraDetailResponse>();
    }

    public class OrderProductExtraDetailResponse
    {
        public Guid ProductInMenuId { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public double FinalAmount { get; set; }
        public double Discount { get; set; }
        public string Name { get; set; }
    }
}