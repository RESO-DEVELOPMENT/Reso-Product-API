using Pos_System.API.Enums;
using Pos_System.API.Utils;

namespace Pos_System.API.Payload.Response.Stores;

public class GetStoreResponse
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Email { get; set; }
    public string? Address { get; set; }
    public StoreStatus Status { get; set; }

    public GetStoreResponse(Guid id, Guid brandId, string name, string shortname, string email, string address, string status)
    {
        Id = id;
        BrandId = brandId;
        Name = name;
        ShortName = shortname;
        Email = email;
        Address = address;
        Status = EnumUtil.ParseEnum<StoreStatus>(status);
    }
}