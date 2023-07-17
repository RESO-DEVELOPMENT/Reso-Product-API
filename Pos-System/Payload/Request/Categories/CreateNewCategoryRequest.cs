using System.ComponentModel.DataAnnotations;
using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Request.Categories;

public class CreateNewCategoryRequest
{
	[MaxLength(20,ErrorMessage = "Code có độ dài tối đa là 20 kí tự")]
	public string Code { get; set; }
	[MaxLength(50,ErrorMessage = "Name có độ dài tối đa là 50 kí tự")]
	public string Name { get; set; }
	public CategoryType CategoryType { get; set; }
	public int DisplayOrder { get; set; }
	public string Description { get; set; }
	public string? PicUrl { get; set; }
	public override string ToString()
	{
		return $"Code: {Code}, Name: {Name}, CategoryType: {CategoryType}, DisplayOrder: {DisplayOrder}, Description: {Description}, PicUrl: {PicUrl}";
	}
}