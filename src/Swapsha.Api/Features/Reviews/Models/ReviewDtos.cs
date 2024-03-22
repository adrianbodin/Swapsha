namespace Swapsha.Api.Features.Reviews.Models;

public record GetReviewsResponse(
    short TotalReviews,
    double AverageRating,
    List<GetReviewsReview> Reviews);

public record GetReviewsReview(
    byte Rating,
    string DateCreated,
    string PostedById);

public record PostReviewRequest(
    byte Rating,
    string UserId);