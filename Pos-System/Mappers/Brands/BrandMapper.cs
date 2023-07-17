using AutoMapper;
using Pos_System.API.Payload.Request.Brands;
using Pos_System.API.Payload.Response.Brands;
using Pos_System.Domain.Models;

namespace Pos_System.API.Mappers.Brands;

public class BrandMapper : Profile
{
    public BrandMapper()
    {
        CreateMap<CreateNewBrandRequest, Brand>();
        CreateMap<Brand, CreateNewBrandResponse>();
    }
}