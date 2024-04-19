using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Features.Users.Exceptions;
using Swapsha.Api.Shared.Data;

namespace Swapsha.Api.Features.Reviews.Services;

public class ReviewService : IReviewService
{
    private readonly AppDbContext _db;

    public ReviewService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<GetReviewsResponse> GetReviewsByUserId(string id)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
            throw new UserNotFoundException($"The user that you are trying to get reviews for does not exist with id: {id}");

        var reviews = await _db.Reviews
            .Where(r => r.UserId == id)
            .Select(r => new GetReviewsReview
            (
                r.Rating,
                r.Comment,
                r.DateCreated.ToString("yyyy-MM-dd"),
                r.PostedById
            ))
            .ToListAsync();

        var averageRating = reviews.Average(r => r.Rating);

        var response = new GetReviewsResponse
        (
            (short)reviews.Count(),
            averageRating,
            reviews
        );

        return response;
    }

    public async Task PostReview(string id, PostReviewRequest request)
    {
        var requestUser = await _db.Users.FirstOrDefaultAsync(u => u.Id == request.UserId);
        if (requestUser == null)
            throw new UserNotFoundException($"The user that you are trying to review does not exist with id: {request.UserId}");

        var review = new Review
        {
            ReviewId = Guid.NewGuid().ToString(),
            Rating = (byte)request.Rating,
            UserId = request.UserId,
            PostedById = id,
            DateCreated = DateTime.Now,
        };

        _db.Reviews.Add(review);
        await _db.SaveChangesAsync();
    }
}