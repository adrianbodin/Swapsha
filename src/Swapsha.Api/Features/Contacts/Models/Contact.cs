using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Contacts.Models;

public class Contact
{
    public string ContactId { get; set; }

    public string User1Id { get; set; }
    public CustomUser User1 { get; set; }

    public string User2Id { get; set; }
    public CustomUser User2 { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}