namespace Swapsha.Api.Models;

public class Review
{
    public int ReviewId { get; set; }

    public byte Rating { get; set; }

    public string UserId { get; set; }
    public CustomUser User { get; set; } = null!;
}