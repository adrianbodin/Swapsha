using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Features.Users.Filters;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Features.Users.Services;
using Swapsha.Api.Shared.Filters;
using Swapsha.Api.Shared.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Users;

[Route("api/v1/users")]
[ApiController]
public class UserEndpoints : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly IImageService _imageService;
    private readonly IUserService _userService;

    public UserEndpoints(
        UserManager<CustomUser> userManager,
        IImageService imageService,
        IUserService userService)
    {
        _userManager = userManager;
        _imageService = imageService;
        _userService = userService;
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get all users",
        Description = "Get all users and their skills and wanted skills, paginated",
        OperationId = "GetAllUsers")]
    [SwaggerResponse(200, "Returns a paginated response of GetAllUsersResponse objects")]
    [SwaggerResponse(500, "If there was a internal server error")]

    #endregion
    [HttpGet]
    public async Task<ActionResult<PaginatedResponse<GetAllUsersResponse>>> GetAllUsers([FromQuery]GetAllUsersRequest request)
    {
        var response = await _userService.GetAllUsers(request);
        return Ok(response);
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get a specific user",
        Description = "Get a specific user based on the id in the route",
        OperationId = "GetUser")]
    [SwaggerResponse(200, "Returns a GetUserResponse object if the operation was successful")]
    [SwaggerResponse(404, "If the user could not be found from the id passed")]
    #endregion
    [HttpGet("{id}")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    public async Task<ActionResult<GetUserResponse>> GetUser(string id)
    {
        var response = await _userService.GetUserById(id);
        return Ok(response);
    }

    [Authorize]
    [HttpPost("{id}/names")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Add user names",
        Description = "Add the firstname, middlename, and lastname to the user.",
        OperationId = "PostNames")]
    [SwaggerResponse(200, "The user names have been updated")]
    [SwaggerResponse(400, "The user names could not be updated")]
    [SwaggerResponse(401, "You are not authorized to perform this action")]
    [SwaggerResponse(500, "An error occurred while adding the user names")]
    #endregion
    public async Task<IActionResult> PostNames([FromBody] PostNamesRequest request, string id)
    {
        var user = HttpContext.Items["User"] as CustomUser;

        user.FirstName = request.FirstName;
        user.MiddleName = request.MiddleName;
        user.LastName = request.LastName;

        var result = await _userManager.UpdateAsync(user);


        return result.Succeeded
            ? Ok()
            : Problem(statusCode: 500, detail:"An error occurred while adding the user names");
    }

    [HttpGet("{id}/names")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get names for a specific user",
        Description = "Get firstname, middlename and lastname from the userid passed as the route parameter",
        OperationId = "GetNames")]
    [SwaggerResponse(200, "Returning the names if the operation was successful")]
    [SwaggerResponse(404, "The user could not be found from the id passed")]
    #endregion
    public async Task<ActionResult<GetNamesResponse>> GetNames(string id)
    {
        var names = await _userService.GetNamesById(id);
        return Ok(names);
    }

    [HttpGet("{id}/firstname")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get the firstname of a specific user",
        Description = "Gets the firstname of a specific user based on the id in the route",
        OperationId = "GetFirstName")]
    [SwaggerResponse(404, "If the route id could not match with a user in the database")]
    [SwaggerResponse(200, "Returns the firstname if successful")]
    #endregion
    public async Task<ActionResult<PostNamesRequest>> GetFirstName(string id)
    {
        var firstName = await _userService.GetFirstNameById(id);
        return Ok(new { firstName });
    }
    
    [Authorize]
    [HttpPatch("{id}/firstname")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Posts a new firstname for a user",
        Description = "Posts a new firstname of the user, only the user hitting the endpoint can change it",
        OperationId = "PostFirstName")]
    [SwaggerResponse(401, "If the id of the route is not the same as the id of the user hitting the endpoint")]
    [SwaggerResponse(400, "If the validation of the Dto was not passed")]
    [SwaggerResponse(201, "Returns the firstname if successful")]
    [SwaggerResponse(500, "If the usermanager returns a not successful result")]
    #endregion
    public async Task<IActionResult> UpdateFirstName(string id, [FromBody] PostFirstNameRequest request)
    {
        var user = HttpContext.Items["User"] as CustomUser;

        user.FirstName = request.FirstName;

        var result = await _userManager.UpdateAsync(user);

        //TODO: make a better return here
        return result.Succeeded
            ? Ok()
            : Problem(statusCode: 500, detail:"An error occurred while adding the firstname");
    }

    [Authorize]
    [HttpPost("{id}/profilepic")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Posts a new profile picture for a specific user",
        Description = @"This endpoint is for adding OR overriding the current picture.
                        Only the user logged in can hit this endpoint and change their picture",
        OperationId = "PostProfilePic")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(201, "If the profile picture has been updated/added successfully")]
    [SwaggerResponse(500, "If there was a internal server error")]
    #endregion
    public async Task<ActionResult<string>> PostProfilePic(string id, IFormFile image)
    {
        var user = HttpContext.Items["User"] as CustomUser;

        var result = await _imageService.AddProfilePic(user.Id, image);

        user.ProfilePictureUrl = result;

        await _userManager.UpdateAsync(user);

        return Created(new Uri(user.ProfilePictureUrl), new { url = result});
    }

    [HttpGet("{id}/profilepic")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets the profile picture url for a specific user",
        Description = @"Gets the url where you can access the profile picture of the user,
                        from the id passed in the route of the request",
        OperationId = "GetProfilePic")]
    [SwaggerResponse(404, "The user could not be found by the id from the route")]
    [SwaggerResponse(200, "Returns the id of the user and the Url to the profile picture")]
    [SwaggerResponse(500, "If there was a internal server error")]
    #endregion
    public async Task<ActionResult<GetProfilePicResponse>> GetProfilePic(string id)
    {
        var response = await _userService.GetProfilePicById(id);

        return Ok(response);
    }

    //TODO: fix better shallow validation for the skillId
    [Authorize]
    [HttpPost("{id}/skills")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Add a skill to a user",
        Description = "Add a skill to a user based on the id in the route and the skill id in the body",
        OperationId = "AddSkillToUser")]
    [SwaggerResponse(404, "If the user or the skill could not be found")]
    [SwaggerResponse(400, "If the user already has the skill")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(200, "If the skill was added to the user")]
    #endregion
    public async Task<IActionResult> AddSkillToUser([FromRoute]string id,[FromBody]int skillId)
    {
        await _userService.AddSkillToUser(id, skillId);
        //TODO: Created return type
        return Ok();
    }

    [Authorize]
    [HttpPost("{id}/wantedskills")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Add a wanted skill to a user",
        Description = "Add a wanted skill to a user based on the id in the route and the skill id in the body",
        OperationId = "AddWantedSkillToUser")]
    [SwaggerResponse(404, "If the user or the skill could not be found")]
    [SwaggerResponse(400, "If the user already has the wanted skill")]
    [SwaggerResponse(401, "If the user hitting the endpoint does not match with the route id")]
    [SwaggerResponse(200, "If the wanted skill was added to the user")]
    #endregion
    public async Task<IActionResult> AddWantedSkillToUser(string id, [FromBody]int skillId)
    {
        await _userService.AddWantedSkillToUser(id, skillId);
        return Ok();
    }


    [Authorize]
    [HttpGet("profile")]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets information about the user hitting the endpoint",
        Description = "Gets the id of the user hitting the endpoint",
        OperationId = "GetProfile")]
    [SwaggerResponse(200, "Returns the id of the user hitting the endpoint")]
    #endregion
    public async Task<ActionResult<GetProfileResponse>> GetProfile()
    {
        var user =  await _userManager.GetUserAsync(HttpContext.User);

        if (user is null)
        {
            return Problem(statusCode: 404, detail: "The user from the http context could not be read");
        }

        var response = await _userService.GetProfile(user);

        return Ok(response);
    }
}