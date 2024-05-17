namespace Swapsha.Api.Features.Contacts.Models;

public record SendContactRequestResponse(string ContactRequestId, string SenderId, string ReceiverId, string Status);

public record SentRequestDto(
    string RequestId,
    string ReceiverId,
    string ReceiverName,
    string Status
);