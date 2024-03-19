namespace Swapsha.Api.Models;

public class Review
{
    public string ReviewId { get; set; }

    public byte Rating { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;

    public string UserId { get; set; }
    public CustomUser User { get; set; } = null!;

    public string PostedById { get; set; }
    public CustomUser PostedByUser { get; set; } = null!;
}