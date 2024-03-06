using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Validations.UserValidations;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly IValidator<UserNamesDto> _unValidator;
    private readonly IValidator<UserFirstNameDto> _fnValidator;

    public UsersController(UserManager<CustomUser> userManager, IValidator<UserNamesDto> unValidator,
        IValidator<UserFirstNameDto> fnValidator)
    {
        _userManager = userManager;
        _unValidator = unValidator;
        _fnValidator = fnValidator;
    }


    [Authorize]
    [HttpPost("{id}/names")]
    [SwaggerOperation(
        Summary = "Add user names",
        Description = "Add the firstname, middlename, and lastname to the user.",
        OperationId = "AddUserNames")]
    [SwaggerResponse(200, "The user names have been updated")]
    [SwaggerResponse(400, "The user names could not be updated")]
    [SwaggerResponse(401, "You are not authorized to perform this action")]
    [SwaggerResponse(500, "An error occurred while adding the user names")]
    public async Task<IActionResult> PostNames([FromBody] UserNamesDto dto, string id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null || user.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var validationResult = _unValidator.Validate(dto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        user.FirstName = dto.FirstName;
        user.MiddleName = dto.MiddleName;
        user.LastName = dto.LastName;

        var result = await _userManager.UpdateAsync(user);
        //TODO better return type
        if (result.Succeeded)
            return Ok("The user names have been updated");

        //TODO better return type
        return Problem(statusCode: 500, detail:"An error occurred while adding the user names");
    }

    [HttpGet("{id}/names")]
    public async Task<ActionResult<UserNamesDto>> GetNames(string id)
    {

        var user = await _userManager.FindByIdAsync(id);

        if (user is null)
            return Problem(statusCode: 404, detail: $"The user could not be found with id: {id}");

        var names = new UserNamesDto
        (
            user.FirstName,
            user.MiddleName,
            user.LastName
        );

        return Ok(names);
    }

    [HttpGet("{id}/firstname")]
    public async Task<ActionResult<UserNamesDto>> GetFirstName(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null)
            return Problem(statusCode: 404, detail: $"The user could not be found with id: {id}");

        return Ok(new { user.FirstName });
    }

    [Authorize]
    [HttpPost("{id}/firstname")]
    public async Task<IActionResult> PostFirstName(string id, [FromBody] UserFirstNameDto dto)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null || user.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");


        var validationResult = _fnValidator.Validate(dto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        user.FirstName = dto.FirstName;

        var result = await _userManager.UpdateAsync(user);
        //TODO better return type
        if (result.Succeeded)
            return Ok();

        //TODO better return type
        return Problem(statusCode: 500, detail:"An error occurred while adding the firstname");
    }

}