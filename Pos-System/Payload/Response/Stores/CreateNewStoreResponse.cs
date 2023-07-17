using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Stores
{
    public class CreateNewStoreResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Code { get; set; }
        public StoreStatus Status { get; set; }
        public Guid BrandId { get; set; }
        public string? Address { get; set; }
    }
}
