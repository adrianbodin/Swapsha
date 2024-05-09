using System.ComponentModel.DataAnnotations;

namespace Swapsha.Api.Features.Reviews.Models;

public record GetReviewsResponse(
    short TotalReviews,
    double AverageRating,
    List<GetReviewsReview> Reviews);

public record GetReviewsReview(
    string ReviewId,
    byte Rating,
    string? Comment,
    string DateCreated,
    string PostedById,
    string PostedBy);

public record PostReviewRequest
{
    [Required(ErrorMessage = "Rating is required.")]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }

    [MaxLength(500, ErrorMessage = "Comment must be less than 500 characters.")]
    public string? Comment { get; set; }

    [Required(ErrorMessage = "UserId is required.")]
    public string UserId { get; set; }
}