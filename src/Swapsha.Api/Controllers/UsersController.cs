﻿using System.Security.Cryptography;
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

    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all users",
        Description = "Get all users and their skills and wanted skills, paginated",
        OperationId = "GetAllUsers")]
    [SwaggerResponse(200, "Returns a paginated response of GetAllUsersResponse objects")]
    [SwaggerResponse(500, "If there was a internal server error")]
    public async Task<ActionResult<PaginatedResponse<GetAllUsersResponse>>> GetAllUsers(int pageIndex = 1, int pageSize = 10)
    {
        var query = _db.Users
            .AsNoTracking()
            .Select(u => new GetAllUsersResponse
            (
                u.FirstName,
                u.LastName,
                u.ProfilePictureUrl,
                u.UserSkills.Select(s => new GetAllUsersSkills(s.Skill.Name, s.Skill.Description)).ToList(),
                u.UserWantedSkills.Select(s => new GetAllUsersSkills(s.Skill.Name, s.Skill.Description)).ToList()
            ));

        var count = await query.CountAsync();

        query = query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize);

        var response = new PaginatedResponse<GetAllUsersResponse>
        {
            PageIndex = pageIndex,
            PageSize = pageSize,
            TotalRecords = count,
            Data = await query.ToListAsync()
        };

        return Ok(response);
    }

    public record GetAllUsersResponse
        (string? FirstName, string? LastName, string? ProfilePictureUrl, List<GetAllUsersSkills> Skills, List<GetAllUsersSkills> WantedSkills);

    public record GetAllUsersSkills
        (string Name, string Description);

    [Authorize]
    [HttpPost("{id}/profilepic")]
    [SwaggerOperation(
        Summary = "Posts a new profile picture for a specific user",
        Description = @"This endpoint is for adding OR overriding the current picture.
                        Only the user logged in can hit this endpoint and change their picture",
        OperationId = "PostProfilePic")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(201, "If the profile picture has been updated/added successfully")]
    [SwaggerResponse(500, "If there was a internal server error")]
    public async Task<ActionResult<string>> PostProfilePic(string id, IFormFile image)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null || user.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var result = await _imageService.AddProfilePic(user.Id, image);

        user.ProfilePictureUrl = result;

        await _userManager.UpdateAsync(user);

        return Created(new Uri(user.ProfilePictureUrl), result);
    }

    [HttpGet("{id}/profilepic")]
    [SwaggerOperation(
        Summary = "Gets the profile picture url for a specific user",
        Description = @"Gets the url where you can access the profile picture of the user,
                        from the id passed in the route of the request",
        OperationId = "GetProfilePic")]
    [SwaggerResponse(404, "The user could not be found by the id from the route")]
    [SwaggerResponse(200, "Returns the id of the user and the Url to the profile picture")]
    [SwaggerResponse(500, "If there was a internal server error")]
    public async Task<ActionResult<GetProfilePicResponse>> GetProfilePic(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user is null)
            return Problem(statusCode: 404, detail: $"The user with id: {id} could not be found");

        var response = new GetProfilePicResponse
        (
            user.Id,
            user.ProfilePictureUrl ?? null
        );

        return Ok(response);
    }

    public record GetProfilePicResponse(string UserId, string? ProfilePicUrl);


    //TODO: refactor this to a cleaner solution
    [Authorize]
    [HttpPost("{id}/skills")]
    [SwaggerOperation(
        Summary = "Add a skill to a user",
        Description = "Add a skill to a user based on the id in the route and the skill id in the body",
        OperationId = "AddSkillToUser")]
    [SwaggerResponse(404, "If the user or the skill could not be found")]
    [SwaggerResponse(400, "If the user already has the skill")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(200, "If the skill was added to the user")]
    public async Task<IActionResult> AddSkillToUser(string id, AddSkillToUserRequest request)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user is null)
            return Problem(statusCode: 404, detail: $"The user with id: {id} could not be found");

        // Check if the user already has the skill
        var alreadyHasSkill = await _db.UserSkills.AnyAsync(us => us.UserId == id && us.SkillId == request.SkillId);

        if (alreadyHasSkill)
            return Problem(statusCode:400, detail: $"The user with id: {id} already has the skill with id: {request.SkillId}");

        var loggedInUser = await _userManager.GetUserAsync(User);
        if (loggedInUser is null || loggedInUser.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var skill = await _db.Skills.FindAsync(request.SkillId);
        if (skill is null)
            return Problem(statusCode: 404, detail: $"The skill with the id: {request.SkillId} could not be found");

        var userSkill = new UserSkill
          {
              SkillId = skill.SkillId,
              UserId = user.Id
          };

        _db.UserSkills.Add(userSkill);

        await _db.SaveChangesAsync();

        //TODO make a better return here
        return Ok();
    }

    public record AddSkillToUserRequest(int SkillId);
    [Authorize]
    [HttpPost("{id}/wantedskills")]
    [SwaggerOperation(
        Summary = "Add a wanted skill to a user",
        Description = "Add a wanted skill to a user based on the id in the route and the skill id in the body",
        OperationId = "AddWantedSkillToUser")]
    [SwaggerResponse(404, "If the user or the skill could not be found")]
    [SwaggerResponse(400, "If the user already has the wanted skill")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(200, "If the wanted skill was added to the user")]
    public async Task<IActionResult> AddWantedSkillToUser(string id, AddWantedSkillToUserRequest request)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user is null)
            return Problem(statusCode: 404, detail: $"The user with id: {id} could not be found");

        // Check if the user already has the wanted skill
        var alreadyHasWantedSkill = await _db.UserWantedSkills.AnyAsync(us => us.UserId == id && us.SkillId == request.SkillId);

        if (alreadyHasWantedSkill)
            return Problem(statusCode:400, detail: $"The user with id: {id} already has the wanted skill with id: {request.SkillId}");

        var loggedInUser = await _userManager.GetUserAsync(User);
        if (loggedInUser is null || loggedInUser.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var skill = await _db.Skills.FindAsync(request.SkillId);
        if (skill is null)
            return Problem(statusCode: 404, detail: $"The skill with the id: {request.SkillId} could not be found");

        var userWantedSkill = new UserWantedSkill
        {
            SkillId = skill.SkillId,
            UserId = user.Id
        };

        _db.UserWantedSkills.Add(userWantedSkill);
        await _db.SaveChangesAsync();

        return Ok();
    }

    public record AddWantedSkillToUserRequest(int SkillId);
}