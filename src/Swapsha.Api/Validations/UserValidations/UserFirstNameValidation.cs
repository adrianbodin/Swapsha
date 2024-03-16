using FluentValidation;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.UserValidations;

public class UserFirstNameValidation : AbstractValidator<PostFirstNameRequest>
{
    public UserFirstNameValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
    }
}