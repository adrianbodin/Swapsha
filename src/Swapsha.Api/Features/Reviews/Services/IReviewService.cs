using Swapsha.Api.Features.Reviews.Models;

namespace Swapsha.Api.Features.Reviews.Services;

public interface IReviewService
{
    Task<GetReviewsResponse> GetReviewsByUserId(string id);
    Task PostReview(string id,PostReviewRequest request);
}