using System.ComponentModel.DataAnnotations;

namespace Pos_System.API.Payload.Request.Collections;

public class CreateNewCollectionRequest
{
	[MaxLength(50,ErrorMessage = "Tên của collection phải dưới 50 kí tự")]
	public string Name { get; set; }
	[MaxLength(20, ErrorMessage = "Code của collection phải dưới 20 kí tự")]
	public string Code { get; set; }

	[MaxLength(100, ErrorMessage = "Miêu tả của collection phải dưới 100 kí tự")]
	public string? Description { get; set; }

	public string? PicUrl { get; set; }

	public void TrimString()
	{
		Name = Name.Trim();
		Code = Code.Trim();
		Description = Description?.Trim();
		PicUrl = PicUrl?.Trim();
	}
}