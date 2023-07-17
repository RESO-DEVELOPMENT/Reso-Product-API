namespace Pos_System.API.Payload.Request.Brands;

public class UpdateAccountStatusRequest
{
	public string Op { get; set; }
	public string Path { get; set; }
	public string Value { get; set; }
}