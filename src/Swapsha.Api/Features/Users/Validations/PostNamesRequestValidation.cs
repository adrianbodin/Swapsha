using FluentValidation;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Validations;

public class PostNamesRequestValidation : AbstractValidator<PostNamesRequest>
{
    public PostNamesRequestValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(dto => dto.MiddleName).MaximumLength(50);
        RuleFor(dto => dto.LastName).NotEmpty().NotNull().MaximumLength(50);
    }
}