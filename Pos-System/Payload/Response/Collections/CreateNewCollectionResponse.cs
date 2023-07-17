using Pos_System.API.Enums;
using Pos_System.API.Utils;

namespace Pos_System.API.Payload.Response.Collections;

public class CreateNewCollectionResponse
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Code { get; set; }
	public CollectionStatus Status { get; set; }
	public string? Description { get; set; }
	public string? PicUrl { get; set; }
	public Guid BrandId { get; set; }

	public CreateNewCollectionResponse(Guid id, string name, string code, string status, string? description, string? picUrl, Guid brandId)
	{
		Id = id;
		Name = name;
		Code = code;
		Status = EnumUtil.ParseEnum<CollectionStatus>(status);
		Description = description;
		PicUrl = picUrl;
		BrandId = brandId;
	}
}