namespace Pos_System.API.Payload.Response.Sessions
{
    public class GetStoreSessionListResponse
    {
        public Guid Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Name { get; set; }
        public int NumberOfOrders { get; set; }
        public double CurrentCashInVault { get; set; }
        public double TotalFinalAmount { get; set; }
    }
}
