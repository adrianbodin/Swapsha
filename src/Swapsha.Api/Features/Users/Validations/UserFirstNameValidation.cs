using FluentValidation;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Validations;

public class UserFirstNameValidation : AbstractValidator<PostFirstNameRequest>
{
    public UserFirstNameValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
    }
}