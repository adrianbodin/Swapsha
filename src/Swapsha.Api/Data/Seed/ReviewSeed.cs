using Swapsha.Api.Models;

namespace Swapsha.Api.Data.Seed;

public class ReviewSeed
{
    public static List<Review> SeedReviews()
    {
        return new List<Review>
        {
            new Review
            {
                ReviewId = 1,
                Rating = 5,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            },
            new Review
            {
                ReviewId = 2,
                Rating = 4,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            },
            new Review
            {
                ReviewId = 3,
                Rating = 3,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            },
            new Review
            {
                ReviewId = 4,
                Rating = 2,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            },
            new Review
            {
                ReviewId = 5,
                Rating = 1,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            },
            new Review
            {
                ReviewId = 6,
                Rating = 5,
                UserId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                PostedById = "4bb59df8-7452-4f98-a399-56fd7eabc66a"
            }
        };
    }
}