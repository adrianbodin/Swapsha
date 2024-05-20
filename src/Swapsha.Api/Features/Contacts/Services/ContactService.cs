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
        var contactRequestExists = await _db.ContactRequests
            .AnyAsync(cr => cr.SenderId == senderId && cr.ReceiverId == receiverId)
            || await _db.ContactRequests
                .AnyAsync(cr => cr.SenderId == receiverId && cr.ReceiverId == senderId);

        if (contactRequestExists)
        {
            throw new ContactRequestExistsException("A contact request already exists between the two users.");
        }

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
        var request = await _db.ContactRequests
            .FirstOrDefaultAsync(cr => cr.ContactRequestId == requestId)
            ?? throw new ContactRequestNotFoundException("The request could not be found");

        return request;
    }

    public async Task<List<SentRequestDto>> GetAllSentRequests(string? userId)
    {
        var requests = await _db.ContactRequests
            .Where(cr => cr.SenderId == userId && cr.Status == ContactRequestStatus.Pending)
            .Select(cr => new SentRequestDto(
                cr.ContactRequestId,
                cr.ReceiverId,
                cr.Receiver.FirstName + " " + cr.Receiver.LastName,
                cr.Receiver.ProfilePictureUrl,
                cr.Status.ToString()
            ))
            .ToListAsync();

        //todo add some error handling here

        return requests;

    }

    public async Task<List<ReceivedRequestDto>> GetAllReceivedRequests(string? userId)
    {
        var requests = await _db.ContactRequests
            .Where(cr => cr.ReceiverId == userId && cr.Status == ContactRequestStatus.Pending)
            .Select(cr => new ReceivedRequestDto(
                cr.ContactRequestId,
                cr.SenderId,
                cr.Sender.FirstName + " " + cr.Sender.LastName,
                cr.Sender.ProfilePictureUrl,
                cr.Status.ToString()
            ))
            .ToListAsync();

        //todo add some error handling here
        return requests ?? [];
    }

    public async Task ApproveContactRequest(string? userId, string id)
    {
        var contactRequest = await _db.ContactRequests
            .Where(cr => cr.ContactRequestId == id && cr.ReceiverId == userId)
            .FirstOrDefaultAsync()
            ?? throw new ContactRequestNotFoundException("The request could not be found");

        var sender = await _db.Users
            .Where(u => u.Id == contactRequest.SenderId)
            .FirstOrDefaultAsync()
            ?? throw new UserNotFoundException($"The sender with ID {contactRequest.SenderId} could not be found");

        var receiver = await _db.Users
            .Where(u => u.Id == userId)
            .FirstOrDefaultAsync()
            ?? throw new UserNotFoundException($"The receiver with ID {userId} could not be found");


        contactRequest.Status = ContactRequestStatus.Accepted;

        receiver.Contacts.Add(sender);
        sender.Contacts.Add(receiver);

        await _db.SaveChangesAsync();
    }

    public async Task<List<ContactDto>> GetAllContacts(string? userId)
    {
        var contacts = await _db.Users
            .Where(u => u.Id == userId)
            .Select(u => u.Contacts.Select(c => new ContactDto(
                    c.Id,
                    c.FirstName + " " + c.LastName,
                    c.ProfilePictureUrl
                    )).ToList()
            )
            .FirstOrDefaultAsync()
            ?? throw new ContactNotFoundException("Contact could not be found for the user");

        return contacts;
    }

    public async Task DeclineContactRequest(string? userId, string id)
    {
        var contactRequest = await _db.ContactRequests
            .Where(cr => cr.ContactRequestId == id && cr.ReceiverId == userId)
            .FirstOrDefaultAsync()
            ?? throw new ContactRequestNotFoundException("The request could not be found");

        contactRequest.Status = ContactRequestStatus.Declined;

        await _db.SaveChangesAsync();
    }
}