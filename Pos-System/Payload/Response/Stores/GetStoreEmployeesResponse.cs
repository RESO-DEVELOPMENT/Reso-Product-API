using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Stores
{
    public class GetStoreEmployeesResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AccountStatus Status { get; set; }
        public RoleEnum Role { get; set; }
        public string Username { get; set; }
    }
}
