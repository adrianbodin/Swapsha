using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Shared.Filters;

namespace Swapsha.Api.Features.Contacts;

[Route("api/v1/users")]
[ApiController]
public class ContactEndpoints : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;

    public ContactEndpoints(UserManager<CustomUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("{id}/contact")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [Authorize]
    public async Task<IActionResult> SendContactRequest(string id)
    {
        return Ok();
    }
}