using FluentValidation;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.UserValidations;

public class UserNamesDtoValidation : AbstractValidator<UserNamesDto>
{
    public UserNamesDtoValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(dto => dto.MiddleName).MaximumLength(50);
        RuleFor(dto => dto.LastName).NotEmpty().NotNull().MaximumLength(50);
    }
}