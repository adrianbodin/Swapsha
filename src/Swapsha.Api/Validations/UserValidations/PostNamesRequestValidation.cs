using FluentValidation;
using Swapsha.Api.Controllers;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Validations.UserValidations;

public class PostNamesRequestValidation : AbstractValidator<PostNamesRequest>
{
    public PostNamesRequestValidation()
    {
        RuleFor(dto => dto.FirstName).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(dto => dto.MiddleName).MaximumLength(50);
        RuleFor(dto => dto.LastName).NotEmpty().NotNull().MaximumLength(50);
    }
}