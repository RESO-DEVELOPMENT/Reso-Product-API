namespace Pos_System.API.Payload.Response.Stores
{
    public class GetStoreEndShiftStatisticsResponse
    {
        public Guid SessionId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Name { get; set; }
        public int NumberOfOrders { get; set; }
        public double TotalAmount { get; set; }
        public int TotalPromotion { get; set; }
        public double CurrentCashInVault { get; set; }
        public double ProfitAmount { get; set; }
        public double TotalDiscountAmount { get; set; }

    }
}
