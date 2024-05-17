using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
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

    public async Task<List<SentRequestDto>> GetAllSentRequests(string? userId)
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

    public async Task<List<ReceivedRequestDto>> GetAllReceivedRequests(string? userId)
    {
        var requests = await _db.ContactRequests
            .Where(cr => cr.ReceiverId == userId)
            .Select(cr => new ReceivedRequestDto(
                cr.ContactRequestId,
                cr.SenderId,
                cr.Sender.FirstName + " " + cr.Sender.LastName,
                cr.Status.ToString()
            ))
            .ToListAsync();

        //todo add some error handling here

        return requests;
    }

    public async Task ApproveContactRequest(string? userId, string id)
    {
        var contactRequest = await _db.ContactRequests
            .Where(cr => cr.ContactRequestId == id && cr.ReceiverId == userId)
            .FirstOrDefaultAsync();

        if (contactRequest is null)
        {
            throw new ContactRequestNotFoundException("The request could not be found");
        }

        var sender = await _db.Users
            .AsNoTracking()
            .Where(u => u.Id == contactRequest.SenderId)
            .FirstOrDefaultAsync();

        var receiver = await _db.Users
            .AsNoTracking()
            .Where(u => u.Id == userId)
            .FirstOrDefaultAsync();

        if (sender is null)
        {
            throw new UserNotFoundException($"The sender with ID {contactRequest.SenderId} could not be found");
        }

        if (receiver is null)
        {
            throw new UserNotFoundException($"The receiver with ID {userId} could not be found");
        }

        contactRequest.Status = ContactRequestStatus.Accepted;

        receiver.Contacts.Add(sender);

        await _db.SaveChangesAsync();
    }
}