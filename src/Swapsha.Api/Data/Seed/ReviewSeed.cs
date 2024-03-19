using Swapsha.Api.Models;

namespace Swapsha.Api.Data.Seed;

public class ReviewSeed
{
    public static List<Review> Seed(List<CustomUser> users)
    {
        var reviews = new List<Review>();
        var random = new Random();

        foreach (var user in users)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(users.Count);
                reviews.Add(new Review
                {
                    ReviewId = Guid.NewGuid().ToString(),
                    Rating = (byte)random.Next(1, 6),
                    UserId = user.Id,
                    PostedById = users[randomIndex].Id
                });
            }
        }

        return reviews;
    }
}