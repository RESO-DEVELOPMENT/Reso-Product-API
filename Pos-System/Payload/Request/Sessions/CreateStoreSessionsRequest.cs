namespace Pos_System.API.Payload.Request.Sessions
{
    public class CreateStoreSessionsRequest
    {
        public List<SessionRequest> Sessions { get; set; }
    }

    public class SessionRequest
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string? Name { get; set; }
    }
}
