using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Accounts
{
    public class CreateNewStoreAccountResponse
    {
        public Guid StoreId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public AccountStatus Status { get; set; }
        public RoleEnum Role { get; set; }
    }
}
