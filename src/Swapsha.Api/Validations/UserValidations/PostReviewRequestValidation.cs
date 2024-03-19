using FluentValidation;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.UserValidations;

public class PostReviewRequestValidation : AbstractValidator<PostReviewRequest>
{
    public PostReviewRequestValidation()
    {
        RuleFor(r => r.Rating)
            .NotEmpty()
            .NotNull()
            .LessThanOrEqualTo(_ => 5)
            .GreaterThanOrEqualTo(_ => 1);
    }
}