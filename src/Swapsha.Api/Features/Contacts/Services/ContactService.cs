using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Features.Contacts.Exceptions;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Users.Exceptions;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Shared.Data;

namespace Swapsha.Api.Features.Contacts.Services;

public class ContactService: IContactService
{
    private readonly AppDbContext _db;

    public ContactService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<ContactRequest> SendContactRequest(string senderId, string receiverId)
    {
        var contactRequest = new ContactRequest
        {
            ContactRequestId = Guid.NewGuid().ToString(),
            SenderId = senderId,
            ReceiverId = receiverId,
            Status = ContactRequestStatus.Pending
        };

        _db.ContactRequests.Add(contactRequest);
        await _db.SaveChangesAsync();

        return contactRequest;
    }

    public async Task<ContactRequest> GetContactRequest(string requestId)
    {
        var request = await _db.ContactRequests.FirstOrDefaultAsync(cr => cr.ContactRequestId == requestId);

        if (request == null)
        {
            throw new ContactRequestNotFoundException("Contact request not found.");
        }

        return request;
    }

    public async Task<List<SentRequestDto>> GetAllSentRequests(string userId)
    {
        var requests = await _db.ContactRequests
            .Where(cr => cr.SenderId == userId)
            .Select(cr => new SentRequestDto(
                cr.ContactRequestId,
                cr.ReceiverId,
                cr.Receiver.FirstName + " " + cr.Receiver.LastName,
                cr.Status.ToString()
            ))
            .ToListAsync();

        //todo add some error handling here

        return requests;

    }
}