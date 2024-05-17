using Swapsha.Api.Features.Contacts.Models;

namespace Swapsha.Api.Features.Contacts.Services;

public interface IContactService
{
    Task<ContactRequest> SendContactRequest(string senderId, string receiverId);

    Task<ContactRequest> GetContactRequest(string requestId);
}