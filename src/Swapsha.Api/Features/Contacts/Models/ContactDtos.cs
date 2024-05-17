namespace Swapsha.Api.Features.Contacts.Models;

public record SendContactRequestResponse(string ContactRequestId, string SenderId, string ReceiverId, string Status);
