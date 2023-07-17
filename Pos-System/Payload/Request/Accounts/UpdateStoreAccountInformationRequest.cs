using System.ComponentModel.DataAnnotations;

namespace Pos_System.API.Payload.Request.Accounts
{
    public class UpdateStoreAccountInformationRequest
    {
        [MaxLength(50, ErrorMessage = "Account name max length is 50 characters")]
        public string? Name { get; set; }

        public string? Password { get; set; }
    }
}
