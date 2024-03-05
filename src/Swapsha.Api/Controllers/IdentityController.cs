using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly IValidator<AddUserNamesDto> _addUserNamesValidator;

    public IdentityController(UserManager<CustomUser> userManager, IValidator<AddUserNamesDto> validator)
    {
        _userManager = userManager;
        _addUserNamesValidator = validator;
    }


    [Authorize]
    [HttpPost("usernames")]
    [SwaggerOperation(
        Summary = "Add user names",
        Description = "Add the firstname, middlename, and lastname to the user.",
        OperationId = "AddUserNames")]
    [SwaggerResponse(200, "The user names have been updated")]
    [SwaggerResponse(400, "The user names could not be updated")]
    [SwaggerResponse(401, "You are not authorized to perform this action")]
    [SwaggerResponse(500, "An error occurred while adding the user names")]
    public async Task<IActionResult> AddUserNames([FromBody] AddUserNamesDto dto)
    {
        var validationResult = _addUserNamesValidator.Validate(dto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized("You are not authorized to perform this action");

        user.FirstName = dto.FirstName;
        user.MiddleName = dto.MiddleName;
        user.LastName = dto.LastName;

        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
            return Ok("The user names have been updated");

        return BadRequest("The user names could not be updated");
    }

}