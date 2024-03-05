using FluentValidation;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.IdentityValidations;

public class AddUserNamesDtoValidation : AbstractValidator<AddUserNamesDto>
{
    public AddUserNamesDtoValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(dto => dto.MiddleName).MaximumLength(50);
        RuleFor(dto => dto.LastName).NotEmpty().NotNull().MaximumLength(50);
    }
}