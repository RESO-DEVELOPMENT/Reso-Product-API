using AutoMapper;
using Pos_System.API.Payload.Request.Stores;
using Pos_System.API.Payload.Response.Stores;
using Pos_System.Domain.Models;

namespace Pos_System.API.Mappers.Stores
{
    public class StoreMapper : Profile
    {
        public StoreMapper()
        {
            CreateMap<CreateNewStoreRequest, Store>();
            CreateMap<Store, CreateNewStoreResponse>();
        }
    }
}
