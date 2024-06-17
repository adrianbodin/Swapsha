using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Chat.Models;

public class Conversation
{
    public int Id { get; set; }
    public Contact Contact { get; set; }
    public ICollection<Message> Messages { get; set; }
}