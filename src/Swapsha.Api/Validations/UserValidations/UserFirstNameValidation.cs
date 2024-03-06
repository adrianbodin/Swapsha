using FluentValidation;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.UserValidations;

public class UserFirstNameValidation : AbstractValidator<UserFirstNameDto>
{
    public UserFirstNameValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
    }
}