using FluentValidation;
using Swapsha.Api.Models;

namespace Swapsha.Api.Validations;

public class CustomUserValidator : AbstractValidator<CustomUser>
{
    public CustomUserValidator()
    {
        RuleFor(u => u.FirstName).NotEmpty().NotNull().MaximumLength(50);
    }
}