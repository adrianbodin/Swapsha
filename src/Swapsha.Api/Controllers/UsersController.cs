using System.Security.Cryptography;
using Azure.Storage.Blobs.Models;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly IValidator<UserNamesDto> _unValidator;
    private readonly IValidator<UserFirstNameDto> _fnValidator;
    private readonly AppDbContext _db;
    private readonly IImageService _imageService;

    public UsersController(
        UserManager<CustomUser> userManager,
        IValidator<UserNamesDto> unValidator,
        IValidator<UserFirstNameDto> fnValidator,
        AppDbContext db,
        IImageService imageService)
    {
        _userManager = userManager;
        _unValidator = unValidator;
        _fnValidator = fnValidator;
        _db = db;
        _imageService = imageService;
    }


    [Authorize]
    [HttpPost("{id}/names")]
    [SwaggerOperation(
        Summary = "Add user names",
        Description = "Add the firstname, middlename, and lastname to the user.",
        OperationId = "PostNames")]
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
            return Ok();

        //TODO better return type
        return Problem(statusCode: 500, detail:"An error occurred while adding the user names");
    }

    [SwaggerOperation(
        Summary = "Get names for a specific user",
        Description = "Get firstname, middlename and lastname from the userid passed as the route parameter",
        OperationId = "GetNames")]
    [SwaggerResponse(200, "Returning the names if the operation was successful")]
    [SwaggerResponse(404, "The user could not be found from the id passed")]
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

    [SwaggerOperation(
        Summary = "Get the firstname of a specific user",
        Description = "Gets the firstname of a specific user based on the id in the route",
        OperationId = "GetFirstName")]
    [SwaggerResponse(404, "If the route id could not match with a user in the database")]
    [SwaggerResponse(200, "Returns the firstname if successful")]
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
    [SwaggerOperation(
        Summary = "Posts a new firstname for a user",
        Description = "Posts a new firstname of the user, only the user hitting the endpoint can change it",
        OperationId = "PostFirstName")]
    [SwaggerResponse(401, "If the id of the route is not the same as the id of the user hitting the endpoint")]
    [SwaggerResponse(400, "If the validation of the Dto was not passed")]
    [SwaggerResponse(201, "Returns the firstname if successful")]
    [SwaggerResponse(500, "If the usermanager returns a not successful result")]
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


    //firstname
    //lastname
    //profile pic
    //List of skills
    //pagination
    [HttpGet]
    public async Task<ActionResult<GetAllUsersResponse>> GetAllUsers()
    {
        var userQuery = _db.Users.AsNoTracking();

        var users = userQuery
            .Select(u => new GetAllUsersResponse
            (
                u.FirstName,
                u.LastName,
                u.ProfilePictureUrl,
                u.Skills.Select(s => new GetAllUsersSkills
                (
                    s.Name,
                    s.Description
                ))
            ))
            .ToListAsync();

        return Ok(users);

    }

    public record GetAllUsersResponse
        (string FirstName, string LastName, string ProfilePictureUrl, IEnumerable<GetAllUsersSkills> skills);

    public record GetAllUsersSkills
        (string Name, string Description);

    [Authorize]
    [HttpPost("{id}/profilepic")]
    public async Task<ActionResult<string>> PostProfilePic(string id, IFormFile image)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null || user.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var result = await _imageService.AddProfilePic(user.Id, image);

        user.ProfilePictureUrl = result;

        await _userManager.UpdateAsync(user);

        return Created();
    }
}