using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Contacts.Services;

public interface IContactService
{
    Task<ContactRequest> SendContactRequest(string senderId, string receiverId);

    Task<ContactRequest> GetContactRequest(string requestId);

    Task<List<SentRequestDto>> GetAllSentRequests(string? userId);

    Task<List<ReceivedRequestDto>> GetAllReceivedRequests(string? userId);

    Task ApproveContactRequest(string? userId, string id);
}