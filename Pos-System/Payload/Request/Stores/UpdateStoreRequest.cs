using System.ComponentModel.DataAnnotations;

namespace Pos_System.API.Payload.Request.Stores
{
    public class UpdateStoreRequest
    {
        [MaxLength(50, ErrorMessage = "Store's name max length is 50 characters")]
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Invalid Phone number")]
        public string? Phone { get; set; }
        public string? Code { get; set; }
        public string? Address { get; set; }

        public UpdateStoreRequest() { }

        public void TrimString()
        {
            Name = Name?.Trim();
            ShortName = ShortName?.Trim();
            Email = Email?.Trim();
            Phone = Phone?.Trim();
            Code = Code?.Trim();
            Address = Address?.Trim();
        }
    }
}
