using Pos_System.API.Payload.Request.Sessions;
using Pos_System.API.Payload.Response.Sessions;
using Pos_System.Domain.Paginate;

namespace Pos_System.API.Services.Interfaces
{
    public interface ISessionService
    {
        Task<bool> CreateStoreSessions(Guid storeId, CreateStoreSessionsRequest createStoreSessionsRequest);
        Task<IPaginate<GetStoreSessionListResponse>> GetStoreSessions(Guid storeId, int page, int size, DateTime? startTime, DateTime? endTime);
        Task<Guid> UpdateStoreSession(Guid storeId, Guid sessionId, UpdateStoreSessionRequest updateStoreSessionRequest);

    }
}
