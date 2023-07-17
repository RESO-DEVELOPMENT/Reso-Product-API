using Microsoft.AspNetCore.Authorization;
using Pos_System.API.Enums;
using Pos_System.API.Utils;

namespace Pos_System.API.Validators;

public class CustomAuthorizeAttribute : AuthorizeAttribute
{
	public CustomAuthorizeAttribute(params RoleEnum[] roleEnums)
	{
		var allowedRolesAsString = roleEnums.Select(x => x.GetDescriptionFromEnum());
		Roles = string.Join(",", allowedRolesAsString);
	}
}