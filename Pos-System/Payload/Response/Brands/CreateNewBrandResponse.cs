using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Brands;

public class CreateNewBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string PicUrl { get; set; }
    public BrandStatus Status { get; set; }
}