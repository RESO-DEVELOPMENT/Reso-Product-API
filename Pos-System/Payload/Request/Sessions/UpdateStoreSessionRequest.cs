namespace Pos_System.API.Payload.Request.Sessions
{
    public class UpdateStoreSessionRequest
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string? Name { get; set; }
        public double? InitCashInVault { get; set; }
    }
}
