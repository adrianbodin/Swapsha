using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Reviews.Models;

public class ReviewSeed
{
    public static List<Review> Seed(List<CustomUser> users)
    {
        var reviews = new List<Review>();
        var random = new Random();

        // Sample comments
        var comments = new string[]
        {
            "Great service!",
            "I had a wonderful experience.",
            "Could be better.",
            "I'm not very satisfied.",
            "Excellent!",
            "I would recommend this service to anyone.",
            "I would not recommend this service to anyone.",
        };

        foreach (var user in users)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(users.Count);
                int randomCommentIndex = random.Next(comments.Length);
                reviews.Add(new Review
                {
                    ReviewId = Guid.NewGuid().ToString(),
                    Rating = (byte)random.Next(1, 6),
                    Comment = comments[randomCommentIndex], // Assign a random comment
                    UserId = user.Id,
                    PostedById = users[randomIndex].Id
                });
            }
        }

        return reviews;
    }
}