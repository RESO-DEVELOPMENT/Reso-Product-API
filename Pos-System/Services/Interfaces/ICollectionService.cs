using Pos_System.API.Payload.Request.Collections;
using Pos_System.API.Payload.Response.Collections;
using Pos_System.API.Payload.Response.Products;
using Pos_System.Domain.Paginate;

namespace Pos_System.API.Services.Interfaces
{
    public interface ICollectionService
    {
        Task<GetCollectionDetailResponse> GetCollectionById(Guid collectionId, string? productName, string? productCode, int page, int size);

        Task<bool> UpdateCollectionInformation(Guid collectionId, UpdateCollectionInformationRequest collectionInformationRequest);

        Task<CreateNewCollectionResponse> CreateNewCollection(CreateNewCollectionRequest createNewCollectionRequest);

        Task<IPaginate<GetCollectionResponse>> GetCollections(string? name, int page, int size);

        Task<IPaginate<GetProductResponse>> GetProductInCollection(Guid collectionId, string? name, int page, int size);

        Task<bool> AddProductsToCollection(Guid collectionId, List<Guid> request);
        Task<Guid> UpdateCollectionStatus(Guid collectionId, UpdateCollectionStatusRequest updateCollectionStatusRequest);
    }
}
