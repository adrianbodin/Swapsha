namespace Swapsha.Api.Features.Contacts.Models;

public record SendContactRequestResponse(string ContactRequestId, string SenderId, string ReceiverId, string Status);

public record SentRequestDto(
    string RequestId,
    string ReceiverId,
    string ReceiverName,
    string ReceiverProfilePic,
    string Status
);

public record ReceivedRequestDto(
    string RequestId,
    string SenderId,
    string SenderName,
    string ProfilePicUrl,
    string Status
);

public record ContactDto(
    string Id,
    string Name,
    string ProfilePictureUrl
);