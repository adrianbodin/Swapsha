using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Chat.Models;

public class Message
{
    public string Id { get; set; }

    public string SenderId { get; set; } = null!;

    public string ReceiverId { get; set; }

    public string Content { get; set; }

    public DateTime SentAt { get; set; }

    public string ConversationId { get; set; }
    public Conversation Conversation { get; set; }
}