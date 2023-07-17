namespace Pos_System.API.Payload.Response.PaymentTypes;

public class GetPaymentTypeDetailResponse
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string? PicUrl { get; set; }
	public bool IsDisplay { get; set; }
	public int? Position { get; set; }
	public Guid BrandId { get; set; }

	public GetPaymentTypeDetailResponse(Guid id, string name, string? picUrl, bool isDisplay, int? position, Guid brandId)
	{
		Id = id;
		Name = name;
		PicUrl = picUrl;
		IsDisplay = isDisplay;
		Position = position;
		BrandId = brandId;
	}
}