using System.ComponentModel.DataAnnotations;

namespace Pos_System.API.Payload.Request.Brands;

public class UpdateBrandRequest
{
	public string? Name { get; set; }
	[EmailAddress(ErrorMessage = "Email sai format")]
	public string? Email { get; set; }
	public string? Address { get; set; }
	[Phone(ErrorMessage = "Phone sai format")]
	public string? Phone { get; set; }
	public string? PicUrl { get; set; }

	public UpdateBrandRequest()
	{
	}

	public void TrimString()
	{
		Name = Name?.Trim();
		Email = Email?.Trim();
		Address = Address?.Trim();
		Phone = Phone?.Trim();
		PicUrl = PicUrl?.Trim();
	}
}