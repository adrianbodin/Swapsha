using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Contacts.Models;

public enum ContactRequestStatus
{
    Pending,
    Accepted,
    Declined
}

public class ContactRequest
{
    public string ContactRequestId { get; set; }

    public string SenderId { get; set; }
    public CustomUser Sender { get; set; }

    public string ReceiverId { get; set; }
    public CustomUser Receiver { get; set; }

    public ContactRequestStatus Status { get; set; }
}