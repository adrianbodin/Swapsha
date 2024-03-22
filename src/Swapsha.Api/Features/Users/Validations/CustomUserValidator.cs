using FluentValidation;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Validations;

public class CustomUserValidator : AbstractValidator<CustomUser>
{
    public CustomUserValidator()
    {
        RuleFor(u => u.FirstName).NotEmpty().NotNull().MaximumLength(50);
    }
}