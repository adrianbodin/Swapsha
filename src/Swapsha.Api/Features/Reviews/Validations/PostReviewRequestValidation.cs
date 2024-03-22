using FluentValidation;
using Swapsha.Api.Features.Reviews.Models;

namespace Swapsha.Api.Features.Reviews.Validations;

public class PostReviewRequestValidation : AbstractValidator<PostReviewRequest>
{
    public PostReviewRequestValidation()
    {
        RuleFor(r => r.Rating)
            .NotEmpty()
            .NotNull()
            .LessThanOrEqualTo(_ => 5)
            .GreaterThanOrEqualTo(_ => 1);

        RuleFor(r => r.UserId)
            .NotEmpty()
            .NotNull()
            .Must(BeAValidGuid).WithMessage("UserId must be a valid GUID.");
    }

    private bool BeAValidGuid(string userId)
    {
        return Guid.TryParse(userId, out _);
    }
}